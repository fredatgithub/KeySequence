using System.Windows.Forms;

namespace KeySequence
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private string _keySequence = string.Empty;

    private void FormMain_Load(object sender, System.EventArgs e)
    {

    }

    private void FormMain_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Right)
      {
        _keySequence += e.KeyCode.ToString();
      }
    }

    private void button_Click(object sender, System.EventArgs e)
    {

    }
  }
}