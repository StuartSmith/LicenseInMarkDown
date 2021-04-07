# License In MarkDown
This repository is to demonstrate how to integrate a markdown Eula or license file into a Win Forms application. The reason for this application is to figure out how to show a Mark down file in a windows forms application. A C# windows form application does not support the displaying of a mark down file. But it is possible in a wpf application. Good news for us is that a windows forms application can host a wpf control on it.  

## Demo Application
The demo application loads the apache lisence file in and displays it in a win forms window.

### Tricky spots
I had trouble trying to get the win forms contol container working through visual studio IDE to recongnise the availablity of a WPF control, to resolve this code was added to the form load of the winforms application.


    private void FormMarkDownViewer_Load(object sender, EventArgs e)
        {
            _markDownViewer = new MarkDownViewer();
            _markDownViewer.InitializeComponent();

            this.elementHost1.Child = _markDownViewer;

            string EulaFile = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "apache-v2.0.md");

            _markDownViewer.Text = File.ReadAllText(EulaFile);
            _markDownViewer.IsReadOnly = true;

        }



