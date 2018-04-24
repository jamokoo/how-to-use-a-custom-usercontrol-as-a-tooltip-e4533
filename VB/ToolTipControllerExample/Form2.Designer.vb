Namespace ToolTipControllerExample
    Partial Public Class Form2
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.marqueeProgressBarControl1 = New DevExpress.XtraEditors.MarqueeProgressBarControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
            CType(Me.marqueeProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' marqueeProgressBarControl1
            ' 
            Me.marqueeProgressBarControl1.Location = New System.Drawing.Point(3, 114)
            Me.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1"
            Me.marqueeProgressBarControl1.Size = New System.Drawing.Size(311, 39)
            Me.marqueeProgressBarControl1.TabIndex = 0
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 14F)
            Me.labelControl1.Location = New System.Drawing.Point(3, 85)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(88, 23)
            Me.labelControl1.TabIndex = 2
            Me.labelControl1.Text = "Locating..."
            ' 
            ' pictureEdit1
            ' 
            Me.pictureEdit1.BackgroundImage = My.Resources.earth_scan
            Me.pictureEdit1.EditValue = My.Resources.earth_scan
            Me.pictureEdit1.Location = New System.Drawing.Point(329, 12)
            Me.pictureEdit1.Name = "pictureEdit1"
            Me.pictureEdit1.Size = New System.Drawing.Size(143, 141)
            Me.pictureEdit1.TabIndex = 1
            ' 
            ' Form2
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(484, 162)
            Me.Controls.Add(Me.labelControl1)
            Me.Controls.Add(Me.pictureEdit1)
            Me.Controls.Add(Me.marqueeProgressBarControl1)
            Me.Name = "Form2"
            Me.Text = "Form2"
            CType(Me.marqueeProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private marqueeProgressBarControl1 As DevExpress.XtraEditors.MarqueeProgressBarControl
        Private pictureEdit1 As DevExpress.XtraEditors.PictureEdit
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace