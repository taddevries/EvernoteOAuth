
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	private global::Gtk.Action FileAction;
	private global::Gtk.Action QuitAction;
	private global::Gtk.VBox vbox1;
	private global::Gtk.MenuBar menubar2;
	private global::Gtk.HBox usernamebox;
	private global::Gtk.Label UsernameLabel;
	private global::Gtk.Entry UsernameEntry;
	private global::Gtk.Alignment alignment12;
	private global::Gtk.HBox passwordbox;
	private global::Gtk.Label PasswordLabel;
	private global::Gtk.Entry PasswordEntry;
	private global::Gtk.Alignment alignment13;
	private global::Gtk.HButtonBox hbuttonbox1;
	private global::Gtk.Button LoginButton;
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	private global::Gtk.TextView textview1;
	private global::Gtk.Statusbar statusbar2;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.FileAction, null);
		this.QuitAction = new global::Gtk.Action ("QuitAction", global::Mono.Unix.Catalog.GetString ("Quit"), null, null);
		this.QuitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Quit");
		w1.Add (this.QuitAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name=\'menubar2\'><menu name=\'FileAction\' action=\'FileAction\'><menuite" +
			"m name=\'QuitAction\' action=\'QuitAction\'/></menu></menubar></ui>");
		this.menubar2 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar2")));
		this.menubar2.Name = "menubar2";
		this.vbox1.Add (this.menubar2);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar2]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.usernamebox = new global::Gtk.HBox ();
		this.usernamebox.Name = "usernamebox";
		this.usernamebox.Homogeneous = true;
		this.usernamebox.Spacing = 6;
		// Container child usernamebox.Gtk.Box+BoxChild
		this.UsernameLabel = new global::Gtk.Label ();
		this.UsernameLabel.Name = "UsernameLabel";
		this.UsernameLabel.Xalign = 1F;
		this.UsernameLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Username");
		this.UsernameLabel.Justify = ((global::Gtk.Justification)(1));
		this.UsernameLabel.SingleLineMode = true;
		this.usernamebox.Add (this.UsernameLabel);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.usernamebox [this.UsernameLabel]));
		w3.Position = 0;
		w3.Expand = false;
		// Container child usernamebox.Gtk.Box+BoxChild
		this.UsernameEntry = new global::Gtk.Entry ();
		this.UsernameEntry.CanFocus = true;
		this.UsernameEntry.Name = "UsernameEntry";
		this.UsernameEntry.IsEditable = true;
		this.UsernameEntry.InvisibleChar = '●';
		this.usernamebox.Add (this.UsernameEntry);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.usernamebox [this.UsernameEntry]));
		w4.Position = 1;
		// Container child usernamebox.Gtk.Box+BoxChild
		this.alignment12 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
		this.alignment12.Name = "alignment12";
		this.usernamebox.Add (this.alignment12);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.usernamebox [this.alignment12]));
		w5.Position = 2;
		this.vbox1.Add (this.usernamebox);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.usernamebox]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.passwordbox = new global::Gtk.HBox ();
		this.passwordbox.Name = "passwordbox";
		this.passwordbox.Homogeneous = true;
		this.passwordbox.Spacing = 6;
		// Container child passwordbox.Gtk.Box+BoxChild
		this.PasswordLabel = new global::Gtk.Label ();
		this.PasswordLabel.Name = "PasswordLabel";
		this.PasswordLabel.Xalign = 1F;
		this.PasswordLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Password");
		this.PasswordLabel.Justify = ((global::Gtk.Justification)(1));
		this.passwordbox.Add (this.PasswordLabel);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.passwordbox [this.PasswordLabel]));
		w7.Position = 0;
		w7.Expand = false;
		// Container child passwordbox.Gtk.Box+BoxChild
		this.PasswordEntry = new global::Gtk.Entry ();
		this.PasswordEntry.CanFocus = true;
		this.PasswordEntry.Name = "PasswordEntry";
		this.PasswordEntry.IsEditable = true;
		this.PasswordEntry.Visibility = false;
		this.PasswordEntry.InvisibleChar = '●';
		this.passwordbox.Add (this.PasswordEntry);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.passwordbox [this.PasswordEntry]));
		w8.Position = 1;
		// Container child passwordbox.Gtk.Box+BoxChild
		this.alignment13 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
		this.alignment13.Name = "alignment13";
		this.passwordbox.Add (this.alignment13);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.passwordbox [this.alignment13]));
		w9.Position = 2;
		this.vbox1.Add (this.passwordbox);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.passwordbox]));
		w10.Position = 2;
		w10.Expand = false;
		w10.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbuttonbox1 = new global::Gtk.HButtonBox ();
		this.hbuttonbox1.Name = "hbuttonbox1";
		// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
		this.LoginButton = new global::Gtk.Button ();
		this.LoginButton.CanFocus = true;
		this.LoginButton.Name = "LoginButton";
		this.LoginButton.UseUnderline = true;
		this.LoginButton.Label = global::Mono.Unix.Catalog.GetString ("Login");
		this.hbuttonbox1.Add (this.LoginButton);
		global::Gtk.ButtonBox.ButtonBoxChild w11 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1 [this.LoginButton]));
		w11.Expand = false;
		w11.Fill = false;
		this.vbox1.Add (this.hbuttonbox1);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbuttonbox1]));
		w12.Position = 3;
		w12.Expand = false;
		w12.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.textview1 = new global::Gtk.TextView ();
		this.textview1.CanFocus = true;
		this.textview1.Name = "textview1";
		this.textview1.Editable = false;
		this.textview1.AcceptsTab = false;
		this.GtkScrolledWindow.Add (this.textview1);
		this.vbox1.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkScrolledWindow]));
		w14.Position = 4;
		// Container child vbox1.Gtk.Box+BoxChild
		this.statusbar2 = new global::Gtk.Statusbar ();
		this.statusbar2.Name = "statusbar2";
		this.statusbar2.Spacing = 6;
		this.vbox1.Add (this.statusbar2);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.statusbar2]));
		w15.Position = 5;
		w15.Expand = false;
		w15.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 507;
		this.DefaultHeight = 447;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.QuitAction.Activated += new global::System.EventHandler (this.OnFileMenuQuitActived);
		this.LoginButton.Clicked += new global::System.EventHandler (this.OnLoginButtonClicked);
	}
}
