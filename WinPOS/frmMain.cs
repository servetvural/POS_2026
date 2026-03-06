

using POSLayer.Models;
using POSLayer.Repository.IRepository;

namespace WinPOS;

public partial class frmMain : Form
{
    private readonly IRepository<User> _userRepository;

    public frmMain(IRepository<User> userRepository)
    {
        InitializeComponent();
        _userRepository = userRepository;
    }

    private async void frmMain_Load(object sender, EventArgs e)
    {
        var users = await _userRepository.GetAllAsync();
        dgv.DataSource = users;
    }
}                                                                                           
