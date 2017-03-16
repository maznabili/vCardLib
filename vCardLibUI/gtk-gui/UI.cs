
// This file has been generated by the GUI designer. Do not modify.

public partial class UI
{
	private global::Gtk.VBox vbox1;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Label label2;

	private global::Gtk.FileChooserButton ofd_select_vcard;

	private global::Gtk.HBox hbox2;

	private global::Gtk.Label label4;

	private global::Gtk.TextView txt_search;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.NodeView dgv_contacts;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget UI
		this.Name = "UI";
		this.Title = global::Mono.Unix.Catalog.GetString("vCardLib UI 1.4");
		this.Icon = new global::Gdk.Pixbuf(global::System.IO.Path.Combine(global::System.AppDomain.CurrentDomain.BaseDirectory, "./vcard.jpg"));
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.Gravity = ((global::Gdk.Gravity)(5));
		// Container child UI.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("File Path:");
		this.hbox1.Add(this.label2);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label2]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.ofd_select_vcard = new global::Gtk.FileChooserButton(global::Mono.Unix.Catalog.GetString("Select a File"), ((global::Gtk.FileChooserAction)(0)));
		this.ofd_select_vcard.Name = "ofd_select_vcard";
		this.hbox1.Add(this.ofd_select_vcard);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.ofd_select_vcard]));
		w2.PackType = ((global::Gtk.PackType)(1));
		w2.Position = 1;
		this.vbox1.Add(this.hbox1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Search:");
		this.hbox2.Add(this.label4);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label4]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.txt_search = new global::Gtk.TextView();
		this.txt_search.CanFocus = true;
		this.txt_search.Name = "txt_search";
		this.txt_search.AcceptsTab = false;
		this.hbox2.Add(this.txt_search);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.txt_search]));
		w5.Position = 1;
		this.vbox1.Add(this.hbox2);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.dgv_contacts = new global::Gtk.NodeView();
		this.dgv_contacts.CanFocus = true;
		this.dgv_contacts.Name = "dgv_contacts";
		this.GtkScrolledWindow.Add(this.dgv_contacts);
		this.vbox1.Add(this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
		w8.Position = 2;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 666;
		this.DefaultHeight = 432;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.ofd_select_vcard.SelectionChanged += new global::System.EventHandler(this.OnOfdSelectVcardSelectionChanged);
	}
}
