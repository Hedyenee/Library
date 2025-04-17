using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
  public partial class SignIn : Form
  {
    public SignIn()
    {
      InitializeComponent();
    }

    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {

    }

    private void SignIn_Load(object sender, EventArgs e)
    {

    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {

    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtUsername_TextAlignChanged(object sender, EventArgs e)
    {

    }

    private void txtUsername_MouseEnter(object sender, EventArgs e)
    {
       
    }

    private void txtUsername_MouseClick(object sender, MouseEventArgs e)
    {

    }

    private void txtPassword_MouseClick(object sender, MouseEventArgs e)
    {
      if(txtPassword.Text=="Password")
      {
        txtPassword.Clear();
        txtPassword.PasswordChar = '*';
      }
    }

    private void pictureBox7_Click(object sender, EventArgs e)
    {

    }

    private void pictureBoxYoutube_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=4vIQON2fDWM");

    }

    private void pictureBoxFacebook_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=4vIQON2fDWM");

    }

    private void pictureBoxInstagram_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=4vIQON2fDWM");

    }

    private void btnLogin_Click(object sender, EventArgs e)
    {

    }
  }
}

