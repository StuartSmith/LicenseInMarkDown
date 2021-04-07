# License in Mark Down
This repository is to demonstrate how to integrate a markdown Eula or license file into a Win Forms C# application.  A C# windows form application does not support the displaying of a mark down file, but it is possible in a WPF application. The Good news for us, is a windows forms application can host a WPF control within it.  

## Demo Application
The demo application loads the apache license file in and displays it in a win forms window.

<img style="float:left;" src="https://raw.githubusercontent.com/StuartSmith/LicenseInMarkDown/master/ScreenShots/LicenseInMarkDown.jpg">


### Tricky spots
I had trouble with in the visual studio IDE for the win forms control container to recognize the availability of a WPF control. (Visual studio did not see any WPF controls within the solution nor projects and because of this it was not possible to bind to them) To resolve this issue the below code was added to the form_load event of the main form.


    private void FormMarkDownViewer_Load(object sender, EventArgs e)
        {
            
            _markDownViewer = new MarkDownViewer();
            _markDownViewer.InitializeComponent();

            this.elementHost1.Child = _markDownViewer;

            string EulaFile = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "apache-v2.0.md");

            _markDownViewer.Text = File.ReadAllText(EulaFile);
            _markDownViewer.IsReadOnly = true;

        }



