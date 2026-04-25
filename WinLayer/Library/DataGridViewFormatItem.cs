
namespace WinLayer;
public class DataGridViewFormatItem
{
    public int index { get; set; }
    public int width { get; set; }
    public string header { get; set; }
    public string content { get; set; }

    public DataGridViewFormatItem()
    {
        List<string> words = new List<string>(); //string , string , string, string
        List<List<string>> lines = new List<List<string>>(); //List<string> , List<string>, List<string
    }
    public DataGridViewFormatItem(int index, int width, string header = "", string content = "")
    {
        this.index = index;
        this.width = width;
        this.header = header;
        this.content = content;
    }

}

public class DataGridViewFormatWord : List<string>
{
    public DataGridViewFormatWord()
    {
    }
}

public class DataGridViewFormatLine
{
    public List<string> words;
    public DataGridViewFormatLine()
    {
        words = new List<string>();
    }
}

public class DataGridViewFormatDocument
{
    public Queue<DataGridViewFormatLine> lines;
    public List<DataGridViewFormatItem> columns;
    public DataGridViewFormatDocument()
    {
        lines = new Queue<DataGridViewFormatLine>();
        columns = new List<DataGridViewFormatItem>();
    }


}
