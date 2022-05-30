namespace W14_JY_070602210044
{
    partial class teamForm
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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Last = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btn_First = new System.Windows.Forms.Button();
            this.dgvMatch = new System.Windows.Forms.DataGridView();
            this.LblWorstDiscipline = new System.Windows.Forms.Label();
            this.LblTopScorer = new System.Windows.Forms.Label();
            this.LblStadium = new System.Windows.Forms.Label();
            this.LblManager = new System.Windows.Forms.Label();
            this.LblTeam = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Last
            // 
            this.btn_Last.Location = new System.Drawing.Point(341, 22);
            this.btn_Last.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Last.Name = "btn_Last";
            this.btn_Last.Size = new System.Drawing.Size(93, 60);
            this.btn_Last.TabIndex = 7;
            this.btn_Last.Text = ">>";
            this.btn_Last.UseVisualStyleBackColor = true;
            this.btn_Last.Click += new System.EventHandler(this.btn_Last_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(233, 22);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(93, 60);
            this.btn_Next.TabIndex = 6;
            this.btn_Next.Text = ">";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Prev
            // 
            this.btn_Prev.Location = new System.Drawing.Point(125, 22);
            this.btn_Prev.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(93, 60);
            this.btn_Prev.TabIndex = 5;
            this.btn_Prev.Text = "<";
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // btn_First
            // 
            this.btn_First.Location = new System.Drawing.Point(17, 22);
            this.btn_First.Margin = new System.Windows.Forms.Padding(4);
            this.btn_First.Name = "btn_First";
            this.btn_First.Size = new System.Drawing.Size(93, 60);
            this.btn_First.TabIndex = 4;
            this.btn_First.Text = "<<";
            this.btn_First.UseVisualStyleBackColor = true;
            this.btn_First.Click += new System.EventHandler(this.btn_First_Click);
            // 
            // dgvMatch
            // 
            this.dgvMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatch.Location = new System.Drawing.Point(19, 270);
            this.dgvMatch.Name = "dgvMatch";
            this.dgvMatch.RowHeadersWidth = 51;
            this.dgvMatch.RowTemplate.Height = 24;
            this.dgvMatch.Size = new System.Drawing.Size(577, 222);
            this.dgvMatch.TabIndex = 25;
            // 
            // LblWorstDiscipline
            // 
            this.LblWorstDiscipline.AutoSize = true;
            this.LblWorstDiscipline.Location = new System.Drawing.Point(168, 232);
            this.LblWorstDiscipline.Name = "LblWorstDiscipline";
            this.LblWorstDiscipline.Size = new System.Drawing.Size(16, 16);
            this.LblWorstDiscipline.TabIndex = 24;
            this.LblWorstDiscipline.Text = "...";
            // 
            // LblTopScorer
            // 
            this.LblTopScorer.AutoSize = true;
            this.LblTopScorer.Location = new System.Drawing.Point(168, 200);
            this.LblTopScorer.Name = "LblTopScorer";
            this.LblTopScorer.Size = new System.Drawing.Size(16, 16);
            this.LblTopScorer.TabIndex = 23;
            this.LblTopScorer.Text = "...";
            // 
            // LblStadium
            // 
            this.LblStadium.AutoSize = true;
            this.LblStadium.Location = new System.Drawing.Point(168, 167);
            this.LblStadium.Name = "LblStadium";
            this.LblStadium.Size = new System.Drawing.Size(16, 16);
            this.LblStadium.TabIndex = 22;
            this.LblStadium.Text = "...";
            // 
            // LblManager
            // 
            this.LblManager.AutoSize = true;
            this.LblManager.Location = new System.Drawing.Point(168, 134);
            this.LblManager.Name = "LblManager";
            this.LblManager.Size = new System.Drawing.Size(16, 16);
            this.LblManager.TabIndex = 21;
            this.LblManager.Text = "...";
            // 
            // LblTeam
            // 
            this.LblTeam.AutoSize = true;
            this.LblTeam.Location = new System.Drawing.Point(168, 104);
            this.LblTeam.Name = "LblTeam";
            this.LblTeam.Size = new System.Drawing.Size(16, 16);
            this.LblTeam.TabIndex = 20;
            this.LblTeam.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Worst Discipline :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Top Scorer :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Stadium :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Manager :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Team Name :";
            // 
            // teamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 499);
            this.Controls.Add(this.dgvMatch);
            this.Controls.Add(this.LblWorstDiscipline);
            this.Controls.Add(this.LblTopScorer);
            this.Controls.Add(this.LblStadium);
            this.Controls.Add(this.LblManager);
            this.Controls.Add(this.LblTeam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Last);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Prev);
            this.Controls.Add(this.btn_First);
            this.Name = "teamForm";
            this.Text = "Team";
            this.Load += new System.EventHandler(this.teamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Last;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button btn_First;
        private System.Windows.Forms.DataGridView dgvMatch;
        private System.Windows.Forms.Label LblWorstDiscipline;
        private System.Windows.Forms.Label LblTopScorer;
        private System.Windows.Forms.Label LblStadium;
        private System.Windows.Forms.Label LblManager;
        private System.Windows.Forms.Label LblTeam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

