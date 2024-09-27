using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizGame
{
    public partial class FormTaoMaQR : Form
    {
        public FormTaoMaQR()
        {
            InitializeComponent();
        }

        private void btnTaoQR_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
            QRCode qRCode = new QRCode(qRCodeGenerator.CreateQrCode(txtTaoQR.Text, QRCodeGenerator.ECCLevel.Q));
            pictureTaoQR.Image = qRCode.GetGraphic(2, Color.Blue, Color.White, false);
            qRCodeGenerator.Dispose();
            qRCode.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
