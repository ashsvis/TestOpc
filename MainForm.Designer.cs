namespace TestOpc
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            opc.Dispose(); // обязательно!!!
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tvServers = new System.Windows.Forms.TreeView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGroup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTag = new System.Windows.Forms.TextBox();
            this.lbServerItems = new System.Windows.Forms.ListBox();
            this.btnRefreshItems = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFetch = new System.Windows.Forms.Button();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Доступные OPC-серверы:";
            // 
            // tvServers
            // 
            this.tvServers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvServers.Location = new System.Drawing.Point(16, 60);
            this.tvServers.Name = "tvServers";
            this.tvServers.Size = new System.Drawing.Size(183, 413);
            this.tvServers.TabIndex = 1;
            this.tvServers.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvServers_AfterSelect);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(48, 31);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "OPC-сервер:";
            // 
            // tbServer
            // 
            this.tbServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbServer.Location = new System.Drawing.Point(208, 392);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(167, 23);
            this.tbServer.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Группа:";
            // 
            // tbGroup
            // 
            this.tbGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbGroup.Location = new System.Drawing.Point(381, 392);
            this.tbGroup.Name = "tbGroup";
            this.tbGroup.Size = new System.Drawing.Size(96, 23);
            this.tbGroup.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Тег:";
            // 
            // tbTag
            // 
            this.tbTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbTag.Location = new System.Drawing.Point(483, 392);
            this.tbTag.Name = "tbTag";
            this.tbTag.Size = new System.Drawing.Size(238, 23);
            this.tbTag.TabIndex = 5;
            // 
            // lbServerItems
            // 
            this.lbServerItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbServerItems.FormattingEnabled = true;
            this.lbServerItems.ItemHeight = 15;
            this.lbServerItems.Location = new System.Drawing.Point(205, 60);
            this.lbServerItems.Name = "lbServerItems";
            this.lbServerItems.Size = new System.Drawing.Size(513, 304);
            this.lbServerItems.TabIndex = 6;
            this.lbServerItems.SelectedIndexChanged += new System.EventHandler(this.lbServerItems_SelectedIndexChanged);
            // 
            // btnRefreshItems
            // 
            this.btnRefreshItems.Location = new System.Drawing.Point(205, 31);
            this.btnRefreshItems.Name = "btnRefreshItems";
            this.btnRefreshItems.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshItems.TabIndex = 2;
            this.btnRefreshItems.Text = "Обновить";
            this.btnRefreshItems.UseVisualStyleBackColor = true;
            this.btnRefreshItems.Click += new System.EventHandler(this.btnRefreshItems_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Доступные  теги OPC-сервера:";
            // 
            // btnFetch
            // 
            this.btnFetch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFetch.Location = new System.Drawing.Point(208, 421);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(75, 23);
            this.btnFetch.TabIndex = 2;
            this.btnFetch.Text = "Опросить";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // tbValue
            // 
            this.tbValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbValue.Location = new System.Drawing.Point(208, 450);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(510, 23);
            this.tbValue.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 485);
            this.Controls.Add(this.lbServerItems);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.tbTag);
            this.Controls.Add(this.tbGroup);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.btnRefreshItems);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tvServers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тест OPC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tvServers;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTag;
        private System.Windows.Forms.ListBox lbServerItems;
        private System.Windows.Forms.Button btnRefreshItems;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.TextBox tbValue;
    }
}

