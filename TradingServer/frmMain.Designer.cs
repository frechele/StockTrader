
namespace TradingServer
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.api = new AxKHOpenAPILib.AxKHOpenAPI();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lbConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbAccounts = new System.Windows.Forms.Label();
            this.cbAccount = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.api)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // api
            // 
            this.api.Enabled = true;
            this.api.Location = new System.Drawing.Point(0, 473);
            this.api.Name = "api";
            this.api.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("api.OcxState")));
            this.api.Size = new System.Drawing.Size(57, 28);
            this.api.TabIndex = 0;
            this.api.Visible = false;
            this.api.OnEventConnect += new AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEventHandler(this.api_OnEventConnect);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbConnectionStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 491);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(900, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lbConnectionStatus
            // 
            this.lbConnectionStatus.Name = "lbConnectionStatus";
            this.lbConnectionStatus.Size = new System.Drawing.Size(87, 17);
            this.lbConnectionStatus.Text = "No connection";
            // 
            // lbAccounts
            // 
            this.lbAccounts.AutoSize = true;
            this.lbAccounts.Location = new System.Drawing.Point(12, 9);
            this.lbAccounts.Name = "lbAccounts";
            this.lbAccounts.Size = new System.Drawing.Size(33, 12);
            this.lbAccounts.TabIndex = 2;
            this.lbAccounts.Text = "계좌:";
            // 
            // cbAccount
            // 
            this.cbAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccount.FormattingEnabled = true;
            this.cbAccount.Location = new System.Drawing.Point(51, 6);
            this.cbAccount.Name = "cbAccount";
            this.cbAccount.Size = new System.Drawing.Size(156, 20);
            this.cbAccount.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 513);
            this.Controls.Add(this.cbAccount);
            this.Controls.Add(this.lbAccounts);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.api);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Trading Server";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.api)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI api;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lbConnectionStatus;
        private System.Windows.Forms.Label lbAccounts;
        private System.Windows.Forms.ComboBox cbAccount;
    }
}

