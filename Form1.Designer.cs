namespace ProtoFileAutoCompiler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainPanel = new Panel();
            panel1 = new Panel();
            label8 = new Label();
            richTextBox1 = new RichTextBox();
            label7 = new Label();
            gRPCWebRepo = new Button();
            label6 = new Label();
            ProtoBufRepo = new Button();
            label5 = new Label();
            btnCompile = new Button();
            txtFolderPath = new TextBox();
            btnSelectFolder = new Button();
            label4 = new Label();
            TopPanel = new Panel();
            label1 = new Label();
            CloseBtn = new Button();
            MainPanel.SuspendLayout();
            panel1.SuspendLayout();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(39, 78, 159);
            MainPanel.Controls.Add(panel1);
            MainPanel.Controls.Add(TopPanel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(937, 524);
            MainPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(gRPCWebRepo);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(ProtoBufRepo);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnCompile);
            panel1.Controls.Add(txtFolderPath);
            panel1.Controls.Add(btnSelectFolder);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(3, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 487);
            panel1.TabIndex = 1;
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(39, 78, 159);
            label8.Location = new Point(43, 477);
            label8.Name = "label8";
            label8.Size = new Size(680, 2);
            label8.TabIndex = 11;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point, 129);
            richTextBox1.ForeColor = Color.FromArgb(39, 78, 159);
            richTextBox1.Location = new Point(43, 170);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(680, 306);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "* 도움말 *\n\nIncloud list\nProtocol Buffers - v27.0\ngRPC-Web - v1.5.0\n\ngRPC-Web 컴파일\n--js_out=import_style=commonjs,mode=grpcweb\n--grpc-web_out=import_style=commonjs,mode=grpcweb";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label7.Location = new Point(41, 75);
            label7.Name = "label7";
            label7.Size = new Size(162, 25);
            label7.TabIndex = 9;
            label7.Text = "gRPC-Web Repo";
            // 
            // gRPCWebRepo
            // 
            gRPCWebRepo.BackColor = Color.FromArgb(39, 78, 159);
            gRPCWebRepo.FlatAppearance.BorderColor = Color.WhiteSmoke;
            gRPCWebRepo.FlatStyle = FlatStyle.Flat;
            gRPCWebRepo.Font = new Font("맑은 고딕", 12F);
            gRPCWebRepo.ForeColor = Color.White;
            gRPCWebRepo.Location = new Point(252, 72);
            gRPCWebRepo.Name = "gRPCWebRepo";
            gRPCWebRepo.Size = new Size(89, 32);
            gRPCWebRepo.TabIndex = 8;
            gRPCWebRepo.Text = "visit";
            gRPCWebRepo.UseVisualStyleBackColor = false;
            gRPCWebRepo.Click += gRPCWebRepo_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label6.Location = new Point(41, 35);
            label6.Name = "label6";
            label6.Size = new Size(212, 25);
            label6.TabIndex = 7;
            label6.Text = "Protocol Buffers Repo";
            // 
            // ProtoBufRepo
            // 
            ProtoBufRepo.BackColor = Color.FromArgb(39, 78, 159);
            ProtoBufRepo.FlatAppearance.BorderColor = Color.WhiteSmoke;
            ProtoBufRepo.FlatStyle = FlatStyle.Flat;
            ProtoBufRepo.Font = new Font("맑은 고딕", 12F);
            ProtoBufRepo.ForeColor = Color.White;
            ProtoBufRepo.Location = new Point(252, 32);
            ProtoBufRepo.Name = "ProtoBufRepo";
            ProtoBufRepo.Size = new Size(89, 32);
            ProtoBufRepo.TabIndex = 3;
            ProtoBufRepo.Text = "visit";
            ProtoBufRepo.UseVisualStyleBackColor = false;
            ProtoBufRepo.Click += ProtoBufRepo_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(39, 78, 159);
            label5.Location = new Point(102, 149);
            label5.Name = "label5";
            label5.Size = new Size(350, 2);
            label5.TabIndex = 6;
            // 
            // btnCompile
            // 
            btnCompile.BackColor = Color.FromArgb(39, 78, 159);
            btnCompile.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnCompile.FlatStyle = FlatStyle.Flat;
            btnCompile.Font = new Font("맑은 고딕", 12F);
            btnCompile.ForeColor = Color.White;
            btnCompile.Location = new Point(634, 122);
            btnCompile.Name = "btnCompile";
            btnCompile.Size = new Size(89, 33);
            btnCompile.TabIndex = 1;
            btnCompile.Text = "Compile";
            btnCompile.UseVisualStyleBackColor = false;
            btnCompile.Click += btnCompile_Click;
            // 
            // txtFolderPath
            // 
            txtFolderPath.BorderStyle = BorderStyle.None;
            txtFolderPath.Font = new Font("맑은 고딕", 12F);
            txtFolderPath.Location = new Point(102, 125);
            txtFolderPath.Name = "txtFolderPath";
            txtFolderPath.ReadOnly = true;
            txtFolderPath.Size = new Size(350, 22);
            txtFolderPath.TabIndex = 5;
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.BackColor = Color.FromArgb(39, 78, 159);
            btnSelectFolder.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnSelectFolder.FlatStyle = FlatStyle.Flat;
            btnSelectFolder.Font = new Font("맑은 고딕", 12F);
            btnSelectFolder.ForeColor = Color.White;
            btnSelectFolder.Location = new Point(458, 122);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(151, 33);
            btnSelectFolder.TabIndex = 4;
            btnSelectFolder.Text = "Select";
            btnSelectFolder.UseVisualStyleBackColor = false;
            btnSelectFolder.Click += btnSelectFolder_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.Location = new Point(43, 125);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 3;
            label4.Text = "Path";
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.White;
            TopPanel.Controls.Add(label1);
            TopPanel.Controls.Add(CloseBtn);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(937, 32);
            TopPanel.TabIndex = 0;
            TopPanel.MouseDown += TopPanel_MouseDown;
            TopPanel.MouseMove += TopPanel_MouseMove;
            TopPanel.MouseUp += TopPanel_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("D2Coding", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.FromArgb(39, 78, 159);
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(253, 22);
            label1.TabIndex = 2;
            label1.Text = "gRPC Protobuf Auto Compiler";
            // 
            // CloseBtn
            // 
            CloseBtn.BackColor = Color.FromArgb(39, 78, 159);
            CloseBtn.FlatAppearance.BorderColor = Color.WhiteSmoke;
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.Font = new Font("맑은 고딕", 12F);
            CloseBtn.ForeColor = Color.White;
            CloseBtn.Location = new Point(848, 0);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(89, 32);
            CloseBtn.TabIndex = 0;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 524);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            MainPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Panel TopPanel;
        private Button CloseBtn;
        private Button btnCompile;
        private Label label1;
        private Panel panel1;
        private Button btnSelectFolder;
        private Label label4;
        private Label label5;
        private TextBox txtFolderPath;
        private Label label6;
        private Button ProtoBufRepo;
        private Label label7;
        private Button gRPCWebRepo;
        private Label label8;
        private RichTextBox richTextBox1;
    }
}
