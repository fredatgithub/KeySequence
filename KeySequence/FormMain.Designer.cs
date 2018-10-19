namespace KeySequence
{
  partial class FormMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.labelSequence = new System.Windows.Forms.Label();
      this.labelOKNOK = new System.Windows.Forms.Label();
      this.labelInstructions = new System.Windows.Forms.Label();
      this.labelKeySeries = new System.Windows.Forms.Label();
      this.buttonGenerateKeySequence = new System.Windows.Forms.Button();
      this.labelActualSequence = new System.Windows.Forms.Label();
      this.labelActualSequenceIP = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // labelSequence
      // 
      this.labelSequence.AutoSize = true;
      this.labelSequence.Location = new System.Drawing.Point(58, 215);
      this.labelSequence.Name = "labelSequence";
      this.labelSequence.Size = new System.Drawing.Size(90, 20);
      this.labelSequence.TabIndex = 0;
      this.labelSequence.Text = "Sequence :";
      // 
      // labelOKNOK
      // 
      this.labelOKNOK.AutoSize = true;
      this.labelOKNOK.Location = new System.Drawing.Point(185, 215);
      this.labelOKNOK.Name = "labelOKNOK";
      this.labelOKNOK.Size = new System.Drawing.Size(111, 20);
      this.labelOKNOK.TabIndex = 1;
      this.labelOKNOK.Text = "OK or NOT OK";
      // 
      // labelInstructions
      // 
      this.labelInstructions.AutoSize = true;
      this.labelInstructions.Location = new System.Drawing.Point(58, 91);
      this.labelInstructions.Name = "labelInstructions";
      this.labelInstructions.Size = new System.Drawing.Size(156, 20);
      this.labelInstructions.TabIndex = 2;
      this.labelInstructions.Text = "Type a series of keys";
      // 
      // labelKeySeries
      // 
      this.labelKeySeries.AutoSize = true;
      this.labelKeySeries.Location = new System.Drawing.Point(373, 91);
      this.labelKeySeries.Name = "labelKeySeries";
      this.labelKeySeries.Size = new System.Drawing.Size(111, 20);
      this.labelKeySeries.TabIndex = 3;
      this.labelKeySeries.Text = "down up down";
      // 
      // buttonGenerateKeySequence
      // 
      this.buttonGenerateKeySequence.Location = new System.Drawing.Point(62, 12);
      this.buttonGenerateKeySequence.Name = "buttonGenerateKeySequence";
      this.buttonGenerateKeySequence.Size = new System.Drawing.Size(223, 44);
      this.buttonGenerateKeySequence.TabIndex = 4;
      this.buttonGenerateKeySequence.Text = "Generate key sequence";
      this.buttonGenerateKeySequence.UseVisualStyleBackColor = true;
      this.buttonGenerateKeySequence.Click += new System.EventHandler(this.Button_Click_GenerateKeySequence);
      // 
      // labelActualSequence
      // 
      this.labelActualSequence.AutoSize = true;
      this.labelActualSequence.Location = new System.Drawing.Point(58, 142);
      this.labelActualSequence.Name = "labelActualSequence";
      this.labelActualSequence.Size = new System.Drawing.Size(139, 20);
      this.labelActualSequence.TabIndex = 5;
      this.labelActualSequence.Text = "Actual Sequence :";
      // 
      // labelActualSequenceIP
      // 
      this.labelActualSequenceIP.AutoSize = true;
      this.labelActualSequenceIP.Location = new System.Drawing.Point(291, 142);
      this.labelActualSequenceIP.Name = "labelActualSequenceIP";
      this.labelActualSequenceIP.Size = new System.Drawing.Size(20, 20);
      this.labelActualSequenceIP.TabIndex = 6;
      this.labelActualSequenceIP.Text = "S";
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(673, 304);
      this.Controls.Add(this.labelActualSequenceIP);
      this.Controls.Add(this.labelActualSequence);
      this.Controls.Add(this.buttonGenerateKeySequence);
      this.Controls.Add(this.labelKeySeries);
      this.Controls.Add(this.labelInstructions);
      this.Controls.Add(this.labelOKNOK);
      this.Controls.Add(this.labelSequence);
      this.Name = "FormMain";
      this.Text = "Key Sequence";
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyUp);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelSequence;
    private System.Windows.Forms.Label labelOKNOK;
    private System.Windows.Forms.Label labelInstructions;
    private System.Windows.Forms.Label labelKeySeries;
    private System.Windows.Forms.Button buttonGenerateKeySequence;
    private System.Windows.Forms.Label labelActualSequence;
    private System.Windows.Forms.Label labelActualSequenceIP;
  }
}

