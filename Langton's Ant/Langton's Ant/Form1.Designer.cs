using System;
using System.Drawing;
using System.Windows.Forms;

namespace Langton_s_Ant
{
    partial class Form1
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
        private void InitializeComponent(int nX, int nY, int boxSize)
        {
            int parametersXOffset = 10;

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(boxSize * nX +260, boxSize * nY);
            this.Text = "Langton's Ant : Step 0";

            this.CanvasBox = new System.Windows.Forms.PictureBox();
            this.ParametersBox = new System.Windows.Forms.GroupBox();
            this.StepsPerDrawTrackBar = new System.Windows.Forms.TrackBar();
            this.StepsPerDrawLab = new System.Windows.Forms.Label();
            this.StepSpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.StepSpeedLab = new System.Windows.Forms.Label();

            /*((System.ComponentModel.ISupportInitialize)(this.CanvasBox)).BeginInit();
            this.ParametersBox.SuspendLayout();
            this.SuspendLayout();*/


            // 
            // StepsPerDrawTrackBar
            // 
            this.StepsPerDrawTrackBar.Location = new System.Drawing.Point(parametersXOffset, 20);
            this.StepsPerDrawTrackBar.Maximum = 100;
            this.StepsPerDrawTrackBar.Minimum = 0;
            this.StepsPerDrawTrackBar.Name = "StepsPerDrawTrackBar";
            this.StepsPerDrawTrackBar.Size = new System.Drawing.Size(250 - 2 * parametersXOffset, 45);
            this.StepsPerDrawTrackBar.TabIndex = 2;
            this.StepsPerDrawTrackBar.TickFrequency = 10;
            this.StepsPerDrawTrackBar.Value = 1;
            this.StepsPerDrawTrackBar.Scroll += new System.EventHandler(this.ChangeStepsPerDraw);
            // 
            // StepsPerDrawLab
            // 
            this.StepsPerDrawLab.AutoSize = true;
            this.StepsPerDrawLab.Location = new System.Drawing.Point(parametersXOffset, 65);
            this.StepsPerDrawLab.Name = "ProbaAliveLab";
            this.StepsPerDrawLab.Size = new System.Drawing.Size(35, 13);
            this.StepsPerDrawLab.TabIndex = 11;
            this.StepsPerDrawLab.Text = "1 step(s) between 2 canvas update";

            // 
            // StepSpeedTrackBar
            // 
            this.StepSpeedTrackBar.Location = new System.Drawing.Point(parametersXOffset, 90);
            this.StepSpeedTrackBar.Maximum = 100;
            this.StepSpeedTrackBar.Minimum = 1;
            this.StepSpeedTrackBar.Name = "StepSpeedTrackBar";
            this.StepSpeedTrackBar.Size = new System.Drawing.Size(250 - 2 * parametersXOffset, 45);
            this.StepSpeedTrackBar.TabIndex = 2;
            this.StepSpeedTrackBar.TickFrequency = 10;
            this.StepSpeedTrackBar.Value = 1;
            this.StepSpeedTrackBar.Scroll += new System.EventHandler(this.ChangeStepSpeed);
            // 
            // StepSpeedLab
            // 
            this.StepSpeedLab.AutoSize = true;
            this.StepSpeedLab.Location = new System.Drawing.Point(parametersXOffset, 135);
            this.StepSpeedLab.Name = "ProbaAliveLab";
            this.StepSpeedLab.Size = new System.Drawing.Size(35, 13);
            this.StepSpeedLab.TabIndex = 11;
            this.StepSpeedLab.Text = "1 step(s) between 2 canvas update";

            // 
            // ParametersBox
            // 
            this.ParametersBox.Controls.Add(this.StepsPerDrawTrackBar);
            this.ParametersBox.Controls.Add(this.StepsPerDrawLab);
            this.ParametersBox.Controls.Add(this.StepSpeedTrackBar);
            this.ParametersBox.Controls.Add(this.StepSpeedLab);
            this.ParametersBox.Location = new System.Drawing.Point(boxSize * nX + 5, 0);
            this.ParametersBox.Name = "ParametersBox";
            this.ParametersBox.Size = new System.Drawing.Size(250, boxSize * nY);
            this.ParametersBox.TabIndex = 2;
            this.ParametersBox.TabStop = false;
            this.ParametersBox.Text = "Parameters";





            // 
            // CanvasBox
            // 
            this.CanvasBox.Location = new System.Drawing.Point(0, 0);
            this.CanvasBox.Name = "CanvasBox";
            this.CanvasBox.Size = new System.Drawing.Size(boxSize * nX, boxSize * nY);
            this.CanvasBox.TabIndex = 0;
            this.CanvasBox.TabStop = false;
            this.CanvasBox.BackColor = Color.Black;
            this.CanvasBox.Paint += new PaintEventHandler(CanvasBox_Paint);

            this.Controls.Add(this.CanvasBox);
            this.Controls.Add(this.ParametersBox);
        }

        #endregion


        private PictureBox CanvasBox;
        private GroupBox ParametersBox;
        private TrackBar StepsPerDrawTrackBar;
        private Label StepsPerDrawLab;
        private TrackBar StepSpeedTrackBar;
        private Label StepSpeedLab;
    }
}

