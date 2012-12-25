
// This file has been generated by the GUI designer. Do not modify.
namespace FontTool
{
	public partial class FontStyleWindow
	{
		private global::Gtk.UIManager UIManager;
		private global::Gtk.Action FileAction;
		private global::Gtk.Action SaveAction;
		private global::Gtk.Action CloseAction;
		private global::Gtk.Action SettingsAction;
		private global::Gtk.Action FontAction;
		private global::Gtk.Action WindowStyleAction;
		private global::Gtk.Action HelpAction;
		private global::Gtk.Action AboutAction;
		private global::Gtk.RadioAction CustomStyleAction;
		private global::Gtk.RadioAction PlatformStyleAction;
		private global::Gtk.RadioAction DecoratedCustomStyleAction;
		private global::Gtk.ToggleAction OnlyEnglishAction;
		private global::Gtk.VBox vbox1;
		private global::Gtk.MenuBar menubar1;
		private global::Gtk.Notebook notebookFont;
		private global::Gtk.VBox vboxFontSettings;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView treeFont;
		private global::Gtk.VBox vboxSamplePreview;
		private global::Gtk.Label lPreview;
		private global::Gtk.DrawingArea preview;
		private global::Gtk.Entry ePreviewSample;
		private global::Gtk.HBox hboxSettings;
		private global::Gtk.Table tableSettings;
		private global::Gtk.CheckButton cbBold;
		private global::Gtk.CheckButton cbItalic;
		private global::Gtk.CheckButton cbStrikeout;
		private global::Gtk.CheckButton cbUnderline;
		private global::Gtk.Label lSize;
		private global::Gtk.Label lStretch;
		private global::Gtk.SpinButton sbSize;
		private global::Gtk.SpinButton sbStretch;
		private global::Gtk.VBox vbox2;
		private global::Gtk.Button btnNextPreview;
		private global::Gtk.Label label1;
		private global::Gtk.VBox vboxBuildPreview;
		private global::Gtk.ScrolledWindow scrolledwindowPreview;
		private global::FontTool.FontPreviewWidget fontPreviewImage;
		private global::Gtk.HBox hboxPreview;
		private global::Gtk.Label lImageSize;
		private global::Gtk.Label lFileSize;
		private global::Gtk.Button btnPrevSettings;
		private global::Gtk.Label label2;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget FontTool.FontStyleWindow
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
			this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
			this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
			w1.Add (this.FileAction, null);
			this.SaveAction = new global::Gtk.Action ("SaveAction", global::Mono.Unix.Catalog.GetString ("Save"), null, null);
			this.SaveAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Save");
			w1.Add (this.SaveAction, null);
			this.CloseAction = new global::Gtk.Action ("CloseAction", global::Mono.Unix.Catalog.GetString ("Close"), null, null);
			this.CloseAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Close");
			w1.Add (this.CloseAction, null);
			this.SettingsAction = new global::Gtk.Action ("SettingsAction", global::Mono.Unix.Catalog.GetString ("Settings"), null, null);
			this.SettingsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Settings");
			w1.Add (this.SettingsAction, null);
			this.FontAction = new global::Gtk.Action ("FontAction", global::Mono.Unix.Catalog.GetString ("Font"), null, null);
			this.FontAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Font");
			w1.Add (this.FontAction, null);
			this.WindowStyleAction = new global::Gtk.Action ("WindowStyleAction", global::Mono.Unix.Catalog.GetString ("Window style"), null, null);
			this.WindowStyleAction.Sensitive = false;
			this.WindowStyleAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Window style");
			this.WindowStyleAction.Visible = false;
			w1.Add (this.WindowStyleAction, null);
			this.HelpAction = new global::Gtk.Action ("HelpAction", global::Mono.Unix.Catalog.GetString ("Help"), null, null);
			this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Help");
			w1.Add (this.HelpAction, null);
			this.AboutAction = new global::Gtk.Action ("AboutAction", global::Mono.Unix.Catalog.GetString ("About"), null, null);
			this.AboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("About");
			w1.Add (this.AboutAction, null);
			this.CustomStyleAction = new global::Gtk.RadioAction ("CustomStyleAction", global::Mono.Unix.Catalog.GetString ("DGLE2"), null, null, 0);
			this.CustomStyleAction.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.CustomStyleAction.Sensitive = false;
			this.CustomStyleAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("DGLE2");
			this.CustomStyleAction.Visible = false;
			w1.Add (this.CustomStyleAction, null);
			this.PlatformStyleAction = new global::Gtk.RadioAction ("PlatformStyleAction", global::Mono.Unix.Catalog.GetString ("Platform"), null, null, 0);
			this.PlatformStyleAction.Group = this.CustomStyleAction.Group;
			this.PlatformStyleAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Platform");
			w1.Add (this.PlatformStyleAction, null);
			this.DecoratedCustomStyleAction = new global::Gtk.RadioAction ("DecoratedCustomStyleAction", global::Mono.Unix.Catalog.GetString ("Decorated DGLE2"), null, null, 0);
			this.DecoratedCustomStyleAction.Group = this.PlatformStyleAction.Group;
			this.DecoratedCustomStyleAction.Sensitive = false;
			this.DecoratedCustomStyleAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Decorated DGLE2");
			this.DecoratedCustomStyleAction.Visible = false;
			w1.Add (this.DecoratedCustomStyleAction, null);
			this.OnlyEnglishAction = new global::Gtk.ToggleAction ("OnlyEnglishAction", global::Mono.Unix.Catalog.GetString ("Only English"), null, null);
			this.OnlyEnglishAction.Active = true;
			this.OnlyEnglishAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Only English");
			w1.Add (this.OnlyEnglishAction, null);
			this.UIManager.InsertActionGroup (w1, 0);
			this.AddAccelGroup (this.UIManager.AccelGroup);
			this.WidthRequest = 536;
			this.HeightRequest = 536;
			this.CanDefault = true;
			this.Name = "FontTool.FontStyleWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("FontTool");
			this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.Resizable = false;
			this.Decorated = false;
			// Container child FontTool.FontStyleWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			// Container child vbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString (@"<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='SaveAction' action='SaveAction'/><menuitem name='CloseAction' action='CloseAction'/></menu><menu name='SettingsAction' action='SettingsAction'><menuitem name='OnlyEnglishAction' action='OnlyEnglishAction'/></menu><menu name='HelpAction' action='HelpAction'><menuitem name='AboutAction' action='AboutAction'/></menu></menubar></ui>");
			this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
			this.menubar1.Name = "menubar1";
			this.vbox1.Add (this.menubar1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.notebookFont = new global::Gtk.Notebook ();
			this.notebookFont.CanFocus = true;
			this.notebookFont.Name = "notebookFont";
			this.notebookFont.CurrentPage = 0;
			this.notebookFont.ShowTabs = false;
			// Container child notebookFont.Gtk.Notebook+NotebookChild
			this.vboxFontSettings = new global::Gtk.VBox ();
			this.vboxFontSettings.Name = "vboxFontSettings";
			this.vboxFontSettings.Spacing = 6;
			this.vboxFontSettings.BorderWidth = ((uint)(6));
			// Container child vboxFontSettings.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeFont = new global::Gtk.TreeView ();
			this.treeFont.CanFocus = true;
			this.treeFont.Name = "treeFont";
			this.GtkScrolledWindow.Add (this.treeFont);
			this.vboxFontSettings.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vboxFontSettings [this.GtkScrolledWindow]));
			w4.Position = 0;
			// Container child vboxFontSettings.Gtk.Box+BoxChild
			this.vboxSamplePreview = new global::Gtk.VBox ();
			this.vboxSamplePreview.Name = "vboxSamplePreview";
			this.vboxSamplePreview.Spacing = 6;
			// Container child vboxSamplePreview.Gtk.Box+BoxChild
			this.lPreview = new global::Gtk.Label ();
			this.lPreview.Name = "lPreview";
			this.lPreview.Xalign = 0F;
			this.lPreview.LabelProp = global::Mono.Unix.Catalog.GetString ("Preview");
			this.vboxSamplePreview.Add (this.lPreview);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vboxSamplePreview [this.lPreview]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vboxSamplePreview.Gtk.Box+BoxChild
			this.preview = new global::Gtk.DrawingArea ();
			this.preview.HeightRequest = 90;
			this.preview.Name = "preview";
			this.vboxSamplePreview.Add (this.preview);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vboxSamplePreview [this.preview]));
			w6.Position = 1;
			// Container child vboxSamplePreview.Gtk.Box+BoxChild
			this.ePreviewSample = new global::Gtk.Entry ();
			this.ePreviewSample.CanFocus = true;
			this.ePreviewSample.Name = "ePreviewSample";
			this.ePreviewSample.Text = global::Mono.Unix.Catalog.GetString ("DGLE2 is here!");
			this.ePreviewSample.IsEditable = true;
			this.ePreviewSample.InvisibleChar = '●';
			this.vboxSamplePreview.Add (this.ePreviewSample);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vboxSamplePreview [this.ePreviewSample]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			this.vboxFontSettings.Add (this.vboxSamplePreview);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vboxFontSettings [this.vboxSamplePreview]));
			w8.Position = 1;
			w8.Expand = false;
			// Container child vboxFontSettings.Gtk.Box+BoxChild
			this.hboxSettings = new global::Gtk.HBox ();
			this.hboxSettings.Name = "hboxSettings";
			this.hboxSettings.Spacing = 6;
			// Container child hboxSettings.Gtk.Box+BoxChild
			this.tableSettings = new global::Gtk.Table (((uint)(2)), ((uint)(4)), true);
			this.tableSettings.Name = "tableSettings";
			this.tableSettings.RowSpacing = ((uint)(12));
			this.tableSettings.ColumnSpacing = ((uint)(12));
			// Container child tableSettings.Gtk.Table+TableChild
			this.cbBold = new global::Gtk.CheckButton ();
			this.cbBold.CanFocus = true;
			this.cbBold.Name = "cbBold";
			this.cbBold.Label = global::Mono.Unix.Catalog.GetString ("Bold");
			this.cbBold.DrawIndicator = true;
			this.cbBold.UseUnderline = true;
			this.tableSettings.Add (this.cbBold);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.tableSettings [this.cbBold]));
			w9.LeftAttach = ((uint)(3));
			w9.RightAttach = ((uint)(4));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableSettings.Gtk.Table+TableChild
			this.cbItalic = new global::Gtk.CheckButton ();
			this.cbItalic.CanFocus = true;
			this.cbItalic.Name = "cbItalic";
			this.cbItalic.Label = global::Mono.Unix.Catalog.GetString ("Italic");
			this.cbItalic.DrawIndicator = true;
			this.cbItalic.UseUnderline = true;
			this.tableSettings.Add (this.cbItalic);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.tableSettings [this.cbItalic]));
			w10.LeftAttach = ((uint)(2));
			w10.RightAttach = ((uint)(3));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableSettings.Gtk.Table+TableChild
			this.cbStrikeout = new global::Gtk.CheckButton ();
			this.cbStrikeout.CanFocus = true;
			this.cbStrikeout.Name = "cbStrikeout";
			this.cbStrikeout.Label = global::Mono.Unix.Catalog.GetString ("Strikeout");
			this.cbStrikeout.DrawIndicator = true;
			this.cbStrikeout.UseUnderline = true;
			this.tableSettings.Add (this.cbStrikeout);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.tableSettings [this.cbStrikeout]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.LeftAttach = ((uint)(3));
			w11.RightAttach = ((uint)(4));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableSettings.Gtk.Table+TableChild
			this.cbUnderline = new global::Gtk.CheckButton ();
			this.cbUnderline.CanFocus = true;
			this.cbUnderline.Name = "cbUnderline";
			this.cbUnderline.Label = global::Mono.Unix.Catalog.GetString ("Underline");
			this.cbUnderline.DrawIndicator = true;
			this.cbUnderline.UseUnderline = true;
			this.tableSettings.Add (this.cbUnderline);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.tableSettings [this.cbUnderline]));
			w12.TopAttach = ((uint)(1));
			w12.BottomAttach = ((uint)(2));
			w12.LeftAttach = ((uint)(2));
			w12.RightAttach = ((uint)(3));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableSettings.Gtk.Table+TableChild
			this.lSize = new global::Gtk.Label ();
			this.lSize.Name = "lSize";
			this.lSize.Xalign = 0F;
			this.lSize.LabelProp = global::Mono.Unix.Catalog.GetString ("Size");
			this.tableSettings.Add (this.lSize);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.tableSettings [this.lSize]));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableSettings.Gtk.Table+TableChild
			this.lStretch = new global::Gtk.Label ();
			this.lStretch.Name = "lStretch";
			this.lStretch.Xalign = 0F;
			this.lStretch.LabelProp = global::Mono.Unix.Catalog.GetString ("Stretch");
			this.tableSettings.Add (this.lStretch);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.tableSettings [this.lStretch]));
			w14.TopAttach = ((uint)(1));
			w14.BottomAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableSettings.Gtk.Table+TableChild
			this.sbSize = new global::Gtk.SpinButton (4D, 72D, 1D);
			this.sbSize.WidthRequest = 80;
			this.sbSize.CanFocus = true;
			this.sbSize.Name = "sbSize";
			this.sbSize.Adjustment.PageIncrement = 10D;
			this.sbSize.ClimbRate = 1D;
			this.sbSize.Numeric = true;
			this.sbSize.Value = 12D;
			this.tableSettings.Add (this.sbSize);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.tableSettings [this.sbSize]));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableSettings.Gtk.Table+TableChild
			this.sbStretch = new global::Gtk.SpinButton (0D, 72D, 1D);
			this.sbStretch.WidthRequest = 80;
			this.sbStretch.CanFocus = true;
			this.sbStretch.Name = "sbStretch";
			this.sbStretch.Adjustment.PageIncrement = 10D;
			this.sbStretch.ClimbRate = 1D;
			this.sbStretch.Numeric = true;
			this.tableSettings.Add (this.sbStretch);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.tableSettings [this.sbStretch]));
			w16.TopAttach = ((uint)(1));
			w16.BottomAttach = ((uint)(2));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hboxSettings.Add (this.tableSettings);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hboxSettings [this.tableSettings]));
			w17.Position = 0;
			w17.Expand = false;
			w17.Fill = false;
			// Container child hboxSettings.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.btnNextPreview = new global::Gtk.Button ();
			this.btnNextPreview.CanFocus = true;
			this.btnNextPreview.Name = "btnNextPreview";
			this.btnNextPreview.UseUnderline = true;
			// Container child btnNextPreview.Gtk.Container+ContainerChild
			global::Gtk.Alignment w18 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w19 = new global::Gtk.HBox ();
			w19.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w20 = new global::Gtk.Image ();
			w20.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-go-forward", global::Gtk.IconSize.Menu);
			w19.Add (w20);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w22 = new global::Gtk.Label ();
			w22.LabelProp = global::Mono.Unix.Catalog.GetString ("Preview");
			w22.UseUnderline = true;
			w19.Add (w22);
			w18.Add (w19);
			this.btnNextPreview.Add (w18);
			this.vbox2.Add (this.btnNextPreview);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.btnNextPreview]));
			w26.PackType = ((global::Gtk.PackType)(1));
			w26.Position = 0;
			w26.Expand = false;
			w26.Fill = false;
			this.hboxSettings.Add (this.vbox2);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hboxSettings [this.vbox2]));
			w27.PackType = ((global::Gtk.PackType)(1));
			w27.Position = 1;
			w27.Expand = false;
			w27.Fill = false;
			this.vboxFontSettings.Add (this.hboxSettings);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vboxFontSettings [this.hboxSettings]));
			w28.Position = 2;
			w28.Expand = false;
			w28.Fill = false;
			w28.Padding = ((uint)(6));
			this.notebookFont.Add (this.vboxFontSettings);
			// Notebook tab
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Settings");
			this.notebookFont.SetTabLabel (this.vboxFontSettings, this.label1);
			this.label1.ShowAll ();
			// Container child notebookFont.Gtk.Notebook+NotebookChild
			this.vboxBuildPreview = new global::Gtk.VBox ();
			this.vboxBuildPreview.Name = "vboxBuildPreview";
			this.vboxBuildPreview.Spacing = 6;
			this.vboxBuildPreview.BorderWidth = ((uint)(6));
			// Container child vboxBuildPreview.Gtk.Box+BoxChild
			this.scrolledwindowPreview = new global::Gtk.ScrolledWindow ();
			this.scrolledwindowPreview.CanFocus = true;
			this.scrolledwindowPreview.Name = "scrolledwindowPreview";
			this.scrolledwindowPreview.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindowPreview.Gtk.Container+ContainerChild
			global::Gtk.Viewport w30 = new global::Gtk.Viewport ();
			w30.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.fontPreviewImage = new global::FontTool.FontPreviewWidget ();
			this.fontPreviewImage.Name = "fontPreviewImage";
			w30.Add (this.fontPreviewImage);
			this.scrolledwindowPreview.Add (w30);
			this.vboxBuildPreview.Add (this.scrolledwindowPreview);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vboxBuildPreview [this.scrolledwindowPreview]));
			w33.Position = 0;
			// Container child vboxBuildPreview.Gtk.Box+BoxChild
			this.hboxPreview = new global::Gtk.HBox ();
			this.hboxPreview.Name = "hboxPreview";
			this.hboxPreview.Spacing = 6;
			// Container child hboxPreview.Gtk.Box+BoxChild
			this.lImageSize = new global::Gtk.Label ();
			this.lImageSize.Name = "lImageSize";
			this.lImageSize.LabelProp = global::Mono.Unix.Catalog.GetString ("Image 0 X 0");
			this.hboxPreview.Add (this.lImageSize);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hboxPreview [this.lImageSize]));
			w34.Position = 0;
			w34.Expand = false;
			w34.Fill = false;
			// Container child hboxPreview.Gtk.Box+BoxChild
			this.lFileSize = new global::Gtk.Label ();
			this.lFileSize.Name = "lFileSize";
			this.lFileSize.LabelProp = global::Mono.Unix.Catalog.GetString ("0 KB");
			this.hboxPreview.Add (this.lFileSize);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hboxPreview [this.lFileSize]));
			w35.Position = 1;
			w35.Expand = false;
			w35.Fill = false;
			// Container child hboxPreview.Gtk.Box+BoxChild
			this.btnPrevSettings = new global::Gtk.Button ();
			this.btnPrevSettings.CanFocus = true;
			this.btnPrevSettings.Name = "btnPrevSettings";
			this.btnPrevSettings.UseUnderline = true;
			// Container child btnPrevSettings.Gtk.Container+ContainerChild
			global::Gtk.Alignment w36 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w37 = new global::Gtk.HBox ();
			w37.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w38 = new global::Gtk.Image ();
			w38.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-go-back", global::Gtk.IconSize.Menu);
			w37.Add (w38);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w40 = new global::Gtk.Label ();
			w40.LabelProp = global::Mono.Unix.Catalog.GetString ("Settings");
			w40.UseUnderline = true;
			w37.Add (w40);
			w36.Add (w37);
			this.btnPrevSettings.Add (w36);
			this.hboxPreview.Add (this.btnPrevSettings);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.hboxPreview [this.btnPrevSettings]));
			w44.PackType = ((global::Gtk.PackType)(1));
			w44.Position = 2;
			w44.Expand = false;
			w44.Fill = false;
			this.vboxBuildPreview.Add (this.hboxPreview);
			global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.vboxBuildPreview [this.hboxPreview]));
			w45.Position = 1;
			w45.Expand = false;
			w45.Fill = false;
			w45.Padding = ((uint)(6));
			this.notebookFont.Add (this.vboxBuildPreview);
			global::Gtk.Notebook.NotebookChild w46 = ((global::Gtk.Notebook.NotebookChild)(this.notebookFont [this.vboxBuildPreview]));
			w46.Position = 1;
			// Notebook tab
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Preview");
			this.notebookFont.SetTabLabel (this.vboxBuildPreview, this.label2);
			this.label2.ShowAll ();
			this.vbox1.Add (this.notebookFont);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.notebookFont]));
			w47.Position = 1;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 536;
			this.DefaultHeight = 536;
			this.HasDefault = true;
			this.Show ();
		}
	}
}