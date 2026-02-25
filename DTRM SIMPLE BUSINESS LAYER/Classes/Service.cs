using System;
using System.Collections.Generic;

using System.ServiceModel;

using System.Data;

namespace DTRMNS {

    [ServiceContract]
    public interface ISimpleBusinessService {
        [OperationContract]
        void EnsureBSLayer();

        [OperationContract]
        string[] GetCategoryList();

        [OperationContract]
        List<SessionDataShort> GetArchivedSessionList();

        [OperationContract]
        string GetDate();

        [OperationContract]
        void ShutDownApplication();

        [OperationContract]
        void RestartApplication();



        [OperationContract]
        bool ReloadSessionListFromDirectory(List<SessionDataShort> theList);

        [OperationContract]
        int GetSessionLoadProgress();


        

        [OperationContract]
        bool ArchiveSessionListToDirectory(List<string> sessionIIDList);

        [OperationContract]
        int GetArchiveProgress();

        

    }

    /* PerCall and PerSession requires bslayer to be instantiated everytime
     * Single is different as long as the program runs the service alive and bslayer no need to be instantiated again
     * Single is a better method but logged user is the same everytime 
     * */

    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.Percall)] 
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)] 
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)] 
    public class SimpleBusinessService : ISimpleBusinessService {
        private DTRMSimpleBusiness bslayer;
        
        public void EnsureBSLayer()
        {
            if (bslayer == null)
                bslayer = new DTRMSimpleBusiness(UF.GetConfig());
        }

        public string[] GetCategoryList()
        {
            //bslayer = new DTRMSimpleBusiness(UF.GetConfig());
            EnsureBSLayer();
            if (bslayer != null)
            {
                DataTable dt =  bslayer.GetEntitiesForMenuDB(bslayer.config.ActiveMenuIID);
                string[] thelist = new string[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    thelist[i] = dt.Rows[i]["EntityName"].ToString();
                }
                return thelist;
            }
            return new string[] { };
        }

        public List<SessionDataShort> GetArchivedSessionList() {
            EnsureBSLayer();
            if (bslayer != null) {
                return bslayer.GetArchivedSessionDataList();
            }
            return new List<SessionDataShort>();
        }

        public string GetDate() {
            return DateTime.Now.ToString();
        }


        public bool ReloadSessionListFromDirectory(List<SessionDataShort> theList) {
            EnsureBSLayer();
            if (bslayer != null) {
                return bslayer.ReloadSessionListFromDirectory(theList);
            }
            return false;
        }
        public int GetSessionLoadProgress() {
             EnsureBSLayer();
             if (bslayer != null) {
                 return bslayer.GetSessionLoadProgress();
             }
             return 0;
        }


        public bool ArchiveSessionListToDirectory(List<string> sessionIIDList) {
             EnsureBSLayer();
             if (bslayer != null) {
                 return bslayer.ArchiveSessionListToDirectory(sessionIIDList);
             }
             return false;
        }

        public int GetArchiveProgress() {
             EnsureBSLayer();
             if (bslayer != null) {
                 return bslayer.GetArchiveProgress();
             }
             return 0;
        }

        public void ShutDownApplication() {
            EnsureBSLayer();
            if (bslayer != null)
                bslayer.ShutDown();
        }

        public void RestartApplication() {
            EnsureBSLayer();
            if (bslayer != null)
                bslayer.Restart();
        }

    }


    public class SimpleBusinessServiceClient : System.ServiceModel.ClientBase<ISimpleBusinessService>, ISimpleBusinessService {
        public SimpleBusinessServiceClient() { }


        public SimpleBusinessServiceClient(string endpointConfigurationName)
            :
                base(endpointConfigurationName) {
        }

        public SimpleBusinessServiceClient(string endpointConfigurationName, string remoteAddress)
            :
                base(endpointConfigurationName, remoteAddress) {
        }

        public SimpleBusinessServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress)
            :
                base(endpointConfigurationName, remoteAddress) {
        }

        public SimpleBusinessServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress)
            :
                base(binding, remoteAddress) {
        }
        public string[] GetCategoryList() {
            return base.Channel.GetCategoryList(); // SampleMethod(msg);
        }

        public List<SessionDataShort> GetArchivedSessionList() {
            return base.Channel.GetArchivedSessionList();
        }

        public string GetDate() {
            return base.Channel.GetDate();
        }

        public void EnsureBSLayer() {
            base.Channel.EnsureBSLayer();
        }


        public void ShutDownApplication() {
            base.Channel.ShutDownApplication();
        }

        public void RestartApplication() {
            base.Channel.RestartApplication();
        }



        public bool ReloadSessionListFromDirectory(List<SessionDataShort> theList) {
            return base.Channel.ReloadSessionListFromDirectory(theList);
        }

        public int GetSessionLoadProgress() {
            return base.Channel.GetSessionLoadProgress();
        }

        

        public bool ArchiveSessionListToDirectory(List<string> sessionIIDList) {
            return base.Channel.ArchiveSessionListToDirectory(sessionIIDList);
        }
        public int GetArchiveProgress() {
            return base.Channel.GetArchiveProgress();
        }
    }
}
