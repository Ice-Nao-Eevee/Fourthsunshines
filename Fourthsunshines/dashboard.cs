using HotelApp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fourthsunshines
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();

            SetHover(btnReservasi);
            SetHover(btnKamar);
            SetHover(btnDataTamu);
        }

        private void SetHover(Button btn)
        {
            Color normal = ColorTranslator.FromHtml("#F7C8D0");
            Color hover = ColorTranslator.FromHtml("#F2B6C6");

            btn.BackColor = normal;

            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = hover;
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = normal;
            };
        }

        private void btnDataTamu_Click(object sender, EventArgs e)
        {
            new DataTamu().Show();
        }

        private void btnKamar_Click(object sender, EventArgs e)
        {
            new FormDataKamar().Show();
        }

        private void btnReservasi_Click(object sender, EventArgs e)
        {
            new FormReservasi().Show();
        }
    }
}
