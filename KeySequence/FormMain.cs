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
        _keySequence += "Right";
      }

      if (e.KeyCode == Keys.Left)
      {
        _keySequence += e.KeyCode.ToString();
      }

      if (e.KeyCode == Keys.Up)
      {
        _keySequence += e.KeyCode.ToString();
      }

      if (e.KeyCode == Keys.Down)
      {
        _keySequence += e.KeyCode.ToString();
      }

      labelActualSequenceIP.Text += _keySequence;
    }

    private void Button_Click_GenerateKeySequence(object sender, System.EventArgs e)
    {

    }

    private void FormMain_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Right)
      {
        _keySequence += e.KeyCode.ToString();
      }

      if (e.KeyCode == Keys.Left)
      {
        _keySequence += e.KeyCode.ToString();
      }

      if (e.KeyCode == Keys.Up)
      {
        _keySequence += e.KeyCode.ToString();
      }

      if (e.KeyCode == Keys.Down)
      {
        _keySequence += e.KeyCode.ToString();
      }

      labelActualSequenceIP.Text += _keySequence;
    }
  }
}