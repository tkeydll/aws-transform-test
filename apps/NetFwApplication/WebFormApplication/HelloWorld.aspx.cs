using System;

namespace WebFormApplication
{
    public partial class HelloWorld : System.Web.UI.Page
    {
        protected void ButtonGreet_Click(object sender, EventArgs e)
        {
            var name = TextBoxName.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                LabelMessage.Text = "���O����͂��Ă��������B";
            }
            else
            {
                LabelMessage.Text = $"Hello, {name}";
            }
        }
    }
}
