namespace CS013NejdelsiSLovo
{
    partial class NejdelsiSlovoForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NejdelsiSlovoForm));
            this.VstupTextBox = new System.Windows.Forms.TextBox();
            this.NejdelsiSlovoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VstupTextBox
            // 
            resources.ApplyResources(this.VstupTextBox, "VstupTextBox");
            this.VstupTextBox.Name = "VstupTextBox";
            this.VstupTextBox.TextChanged += new System.EventHandler(this.VstupTextBox_TextChanged);
            // 
            // NejdelsiSlovoLabel
            // 
            resources.ApplyResources(this.NejdelsiSlovoLabel, "NejdelsiSlovoLabel");
            this.NejdelsiSlovoLabel.Name = "NejdelsiSlovoLabel";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // NejdelsiSlovoForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NejdelsiSlovoLabel);
            this.Controls.Add(this.VstupTextBox);
            this.Name = "NejdelsiSlovoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VstupTextBox;
        private System.Windows.Forms.Label NejdelsiSlovoLabel;
        private System.Windows.Forms.Label label1;
    }
}

