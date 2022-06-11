using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingServer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void FatalError(string message)
        {
            MessageBox.Show(message, "Trading Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (api.CommConnect() != 0)
                FatalError("로그인에 실패했습니다.");
        }

        private void api_OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if (e.nErrCode != 0)
                FatalError("로그인에 실패했습니다.");

            lbConnectionStatus.Text = "Connected";
        }
    }
}
