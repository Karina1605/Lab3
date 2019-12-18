namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TInput = new System.Windows.Forms.TextBox();
            this.BEnter = new System.Windows.Forms.Button();
            this.TOutput = new System.Windows.Forms.TextBox();
            this.BClear = new System.Windows.Forms.Button();
            this.LInput = new System.Windows.Forms.Label();
            this.LOutput = new System.Windows.Forms.Label();
            this.TStartTree = new System.Windows.Forms.TreeView();
            this.TFinishTree = new System.Windows.Forms.TreeView();
            this.TreeFirst = new System.Windows.Forms.Label();
            this.LSecondTree = new System.Windows.Forms.Label();
            this.BTask = new System.Windows.Forms.Button();
            this.BExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TInput
            // 
            this.TInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TInput.Location = new System.Drawing.Point(21, 41);
            this.TInput.Name = "TInput";
            this.TInput.Size = new System.Drawing.Size(416, 27);
            this.TInput.TabIndex = 0;
            // 
            // BEnter
            // 
            this.BEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BEnter.Location = new System.Drawing.Point(483, 40);
            this.BEnter.Name = "BEnter";
            this.BEnter.Size = new System.Drawing.Size(131, 28);
            this.BEnter.TabIndex = 1;
            this.BEnter.Text = "Enter";
            this.BEnter.UseVisualStyleBackColor = true;
            this.BEnter.Click += new System.EventHandler(this.BEnter_Click);
            // 
            // TOutput
            // 
            this.TOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TOutput.Location = new System.Drawing.Point(21, 116);
            this.TOutput.Name = "TOutput";
            this.TOutput.ReadOnly = true;
            this.TOutput.Size = new System.Drawing.Size(416, 27);
            this.TOutput.TabIndex = 2;
            // 
            // BClear
            // 
            this.BClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BClear.Location = new System.Drawing.Point(483, 115);
            this.BClear.Name = "BClear";
            this.BClear.Size = new System.Drawing.Size(131, 28);
            this.BClear.TabIndex = 3;
            this.BClear.Text = "Clear Tree";
            this.BClear.UseVisualStyleBackColor = true;
            this.BClear.Click += new System.EventHandler(this.BClear_Click);
            // 
            // LInput
            // 
            this.LInput.AutoSize = true;
            this.LInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LInput.Location = new System.Drawing.Point(21, 18);
            this.LInput.Name = "LInput";
            this.LInput.Size = new System.Drawing.Size(169, 20);
            this.LInput.TabIndex = 4;
            this.LInput.Text = "Input expression here";
            // 
            // LOutput
            // 
            this.LOutput.AutoSize = true;
            this.LOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LOutput.Location = new System.Drawing.Point(21, 93);
            this.LOutput.Name = "LOutput";
            this.LOutput.Size = new System.Drawing.Size(148, 20);
            this.LOutput.TabIndex = 5;
            this.LOutput.Text = "After simplification";
            // 
            // TStartTree
            // 
            this.TStartTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TStartTree.Location = new System.Drawing.Point(21, 183);
            this.TStartTree.Name = "TStartTree";
            this.TStartTree.Size = new System.Drawing.Size(416, 238);
            this.TStartTree.TabIndex = 6;
            // 
            // TFinishTree
            // 
            this.TFinishTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TFinishTree.Location = new System.Drawing.Point(596, 183);
            this.TFinishTree.Name = "TFinishTree";
            this.TFinishTree.Size = new System.Drawing.Size(416, 238);
            this.TFinishTree.TabIndex = 7;
            // 
            // TreeFirst
            // 
            this.TreeFirst.AutoSize = true;
            this.TreeFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TreeFirst.Location = new System.Drawing.Point(21, 159);
            this.TreeFirst.Name = "TreeFirst";
            this.TreeFirst.Size = new System.Drawing.Size(84, 20);
            this.TreeFirst.TabIndex = 8;
            this.TreeFirst.Text = "Start Tree";
            // 
            // LSecondTree
            // 
            this.LSecondTree.AutoSize = true;
            this.LSecondTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LSecondTree.Location = new System.Drawing.Point(592, 159);
            this.LSecondTree.Name = "LSecondTree";
            this.LSecondTree.Size = new System.Drawing.Size(93, 20);
            this.LSecondTree.TabIndex = 9;
            this.LSecondTree.Text = "Finish Tree";
            // 
            // BTask
            // 
            this.BTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTask.Location = new System.Drawing.Point(634, 75);
            this.BTask.Name = "BTask";
            this.BTask.Size = new System.Drawing.Size(131, 28);
            this.BTask.TabIndex = 10;
            this.BTask.Text = "Make The Task";
            this.BTask.UseVisualStyleBackColor = true;
            this.BTask.Click += new System.EventHandler(this.BTask_Click);
            // 
            // BExit
            // 
            this.BExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BExit.Location = new System.Drawing.Point(888, 18);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(131, 28);
            this.BExit.TabIndex = 11;
            this.BExit.Text = "Exit";
            this.BExit.UseVisualStyleBackColor = true;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 472);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.BTask);
            this.Controls.Add(this.LSecondTree);
            this.Controls.Add(this.TreeFirst);
            this.Controls.Add(this.TFinishTree);
            this.Controls.Add(this.TStartTree);
            this.Controls.Add(this.LOutput);
            this.Controls.Add(this.LInput);
            this.Controls.Add(this.BClear);
            this.Controls.Add(this.TOutput);
            this.Controls.Add(this.BEnter);
            this.Controls.Add(this.TInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TInput;
        private System.Windows.Forms.Button BEnter;
        private System.Windows.Forms.TextBox TOutput;
        private System.Windows.Forms.Button BClear;
        private System.Windows.Forms.Label LInput;
        private System.Windows.Forms.Label LOutput;
        private System.Windows.Forms.TreeView TStartTree;
        private System.Windows.Forms.TreeView TFinishTree;
        private System.Windows.Forms.Label TreeFirst;
        private System.Windows.Forms.Label LSecondTree;
        private System.Windows.Forms.Button BTask;
        private System.Windows.Forms.Button BExit;
    }
}

