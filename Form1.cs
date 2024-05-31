using System.Diagnostics;

namespace ProtoFileAutoCompiler
{
    public partial class Form1 : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public Form1()
        {
            InitializeComponent();
        }
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFolderPath.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private string GetProtocPath()
        {
            // ������Ʈ�� win64 ���͸� ���� protoc.exe�� �ִٰ� �����մϴ�.
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var protocPath = Path.Combine(baseDirectory, "protoc", "win64", "protoc.exe");

            if (File.Exists(protocPath))
            {
                return protocPath;
            }

            throw new FileNotFoundException("protoc.exe not found.");
        }

        private void CompileProto(string protoPath, string outputDir, string language)
        {
            string protocPath = GetProtocPath();
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var includePath = Path.Combine(baseDirectory, "protoc", "include");
            var protoDirectory = Path.GetDirectoryName(protoPath);

            string arguments;

            if (language == "js")
            {
                var grpcWebPluginPath = Path.Combine(baseDirectory, "protoc", "win64", "protoc-gen-grpc-web-1.5.0-windows-x86_64.exe");
                var jsOutputDir = Path.Combine(outputDir, "js");
                var grpcWebOutputDir = Path.Combine(outputDir, "grpc-web");
                Directory.CreateDirectory(jsOutputDir);
                Directory.CreateDirectory(grpcWebOutputDir);
                arguments = $"--proto_path={protoDirectory} --proto_path={includePath} --js_out=import_style=commonjs,mode=grpcweb:{jsOutputDir} --grpc-web_out=import_style=commonjs,mode=grpcweb:{grpcWebOutputDir} --plugin=protoc-gen-grpc-web={grpcWebPluginPath} {Path.GetFileName(protoPath)}";
            }
            else
            {
                arguments = $"--proto_path={protoDirectory} --proto_path={includePath} --{language}_out={outputDir} {Path.GetFileName(protoPath)}";
            }


            Process process = new Process();
            process.StartInfo.FileName = protocPath;
            process.StartInfo.Arguments = arguments;
            process.StartInfo.WorkingDirectory = protoDirectory; // �۾� ���丮�� .proto ������ ���丮�� ����
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            process.WaitForExit();

            if (process.ExitCode != 0)
            {
                throw new Exception($"'{Path.GetFileName(protoPath)}' ������ '{language}' ���� �������ϴ� �� �����߽��ϴ�. ����: {error}");
            }
        }


        private void btnCompile_Click(object sender, EventArgs e)
        {
            string folderPath = txtFolderPath.Text;
            if (string.IsNullOrEmpty(folderPath) || !Directory.Exists(folderPath))
            {
                MessageBox.Show("Please select a valid folder.");
                return;
            }

            string[] protoFiles = Directory.GetFiles(folderPath, "*.proto");
            string[] languages = { "csharp", "java", "js", "python", "dart" };

            foreach (string protoFile in protoFiles)
            {
                foreach (string language in languages)
                {
                    string outputDir = Path.Combine(folderPath, "output", language);
                    Directory.CreateDirectory(outputDir);
                    try
                    {
                        CompileProto(protoFile, outputDir, language);
                    }
                    catch (Exception ex)
                    {
                        string fileName = Path.GetFileName(protoFile);
                        MessageBox.Show($"'{fileName}' ������ '{language}' ���� �������ϴ� �� �����߽��ϴ�. ����: {ex.Message}");
                    }
                }
            }

            MessageBox.Show("Compilation completed.");
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void ProtoBufRepo_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/protocolbuffers/protobuf/releases";
            //����� PC�� �⺻ �������� ���� URL ����
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"URL�� ���� �� �����߽��ϴ�. ����: {ex.Message}");
            }
        }

        private void gRPCWebRepo_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/grpc/grpc-web";
            //����� PC�� �⺻ �������� ���� URL ����
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"URL�� ���� �� �����߽��ϴ�. ����: {ex.Message}");
            }
        }
    }
}
