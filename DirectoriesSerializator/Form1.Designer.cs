namespace DirectoriesSerializator
{
    partial class Form1
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
            this.SerializeButton = new System.Windows.Forms.Button();
            this.DeserializeButton = new System.Windows.Forms.Button();
            this.textBoxSerialPath = new System.Windows.Forms.TextBox();
            this.textBoxDeserialPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDatFilePath = new System.Windows.Forms.TextBox();
            this.datFileButton = new System.Windows.Forms.Button();
            this.serializeStartButton = new System.Windows.Forms.Button();
            this.deserializeStartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SerializeButton
            // 
            this.SerializeButton.Location = new System.Drawing.Point(342, 28);
            this.SerializeButton.Name = "SerializeButton";
            this.SerializeButton.Size = new System.Drawing.Size(75, 23);
            this.SerializeButton.TabIndex = 0;
            this.SerializeButton.Text = "Choose...";
            this.SerializeButton.UseVisualStyleBackColor = true;
            this.SerializeButton.Click += new System.EventHandler(this.SerializeButton_Click);
            // 
            // DeserializeButton
            // 
            this.DeserializeButton.Location = new System.Drawing.Point(342, 79);
            this.DeserializeButton.Name = "DeserializeButton";
            this.DeserializeButton.Size = new System.Drawing.Size(75, 23);
            this.DeserializeButton.TabIndex = 1;
            this.DeserializeButton.Text = "Choose...";
            this.DeserializeButton.UseVisualStyleBackColor = true;
            this.DeserializeButton.Click += new System.EventHandler(this.DeserializeButton_Click);
            // 
            // textBoxSerialPath
            // 
            this.textBoxSerialPath.Location = new System.Drawing.Point(31, 31);
            this.textBoxSerialPath.Name = "textBoxSerialPath";
            this.textBoxSerialPath.Size = new System.Drawing.Size(305, 20);
            this.textBoxSerialPath.TabIndex = 2;
            // 
            // textBoxDeserialPath
            // 
            this.textBoxDeserialPath.Location = new System.Drawing.Point(31, 81);
            this.textBoxDeserialPath.Name = "textBoxDeserialPath";
            this.textBoxDeserialPath.Size = new System.Drawing.Size(305, 20);
            this.textBoxDeserialPath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose folder which you want to serialize:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choose folder where you want move deserealised objects:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Choose folder for .dat file:";
            // 
            // textBoxDatFilePath
            // 
            this.textBoxDatFilePath.Location = new System.Drawing.Point(31, 135);
            this.textBoxDatFilePath.Name = "textBoxDatFilePath";
            this.textBoxDatFilePath.Size = new System.Drawing.Size(305, 20);
            this.textBoxDatFilePath.TabIndex = 7;
            // 
            // datFileButton
            // 
            this.datFileButton.Location = new System.Drawing.Point(342, 133);
            this.datFileButton.Name = "datFileButton";
            this.datFileButton.Size = new System.Drawing.Size(75, 23);
            this.datFileButton.TabIndex = 6;
            this.datFileButton.Text = "Choose...";
            this.datFileButton.UseVisualStyleBackColor = true;
            this.datFileButton.Click += new System.EventHandler(this.datFileButton_Click);
            // 
            // serializeStartButton
            // 
            this.serializeStartButton.Location = new System.Drawing.Point(108, 170);
            this.serializeStartButton.Name = "serializeStartButton";
            this.serializeStartButton.Size = new System.Drawing.Size(75, 23);
            this.serializeStartButton.TabIndex = 9;
            this.serializeStartButton.Text = "Serialize";
            this.serializeStartButton.UseVisualStyleBackColor = true;
            this.serializeStartButton.Click += new System.EventHandler(this.serializeStartButton_Click);
            // 
            // deserializeStartButton
            // 
            this.deserializeStartButton.Location = new System.Drawing.Point(240, 170);
            this.deserializeStartButton.Name = "deserializeStartButton";
            this.deserializeStartButton.Size = new System.Drawing.Size(75, 23);
            this.deserializeStartButton.TabIndex = 10;
            this.deserializeStartButton.Text = "Deserialize";
            this.deserializeStartButton.UseVisualStyleBackColor = true;
            this.deserializeStartButton.Click += new System.EventHandler(this.deserializeStartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 205);
            this.Controls.Add(this.deserializeStartButton);
            this.Controls.Add(this.serializeStartButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDatFilePath);
            this.Controls.Add(this.datFileButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDeserialPath);
            this.Controls.Add(this.textBoxSerialPath);
            this.Controls.Add(this.DeserializeButton);
            this.Controls.Add(this.SerializeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SerializeButton;
        private System.Windows.Forms.Button DeserializeButton;
        private System.Windows.Forms.TextBox textBoxSerialPath;
        private System.Windows.Forms.TextBox textBoxDeserialPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDatFilePath;
        private System.Windows.Forms.Button datFileButton;
        private System.Windows.Forms.Button serializeStartButton;
        private System.Windows.Forms.Button deserializeStartButton;
    }
}

