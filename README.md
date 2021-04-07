# License In MarkDown
This repository is to demonstrate how to integrate a markdown Eula or license file into a Win Forms application. The reason for this application is to figure out how to show a Mark down file in a windows forms application. A C# windows form application does not support the displaying of a mark down file, but it is possible in a wpf application. The Good news for us is that a windows forms application can host a wpf control with in it.  

## Demo Application
The demo application loads the apache lisence file in and displays it in a win forms window.


### Tricky spots
I had trouble trying to  with in the visual studio IDE fir the win forms contol container  to recongnise the availablity of a WPF control, to resolve this the code was added to the form_load event of the winforms application to work around this limitation. 


    private void FormMarkDownViewer_Load(object sender, EventArgs e)
        {
            
            _markDownViewer = new MarkDownViewer();
            _markDownViewer.InitializeComponent();

            this.elementHost1.Child = _markDownViewer;

            string EulaFile = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "apache-v2.0.md");

            _markDownViewer.Text = File.ReadAllText(EulaFile);
            _markDownViewer.IsReadOnly = true;

        }



