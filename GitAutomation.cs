using System;
using System.Diagnostics;

class GitAutomation
{
    static void Main(string[] args)
    {
        string repoPath = @"C:\Path\To\Your\Repository";
        string commitMessage = "Automated commit from C#";

        try
        {
            Console.WriteLine("Starting Git operations...");

            // Step 1: Stage all changes
            RunGitCommand("add .", repoPath);
            Console.WriteLine("All changes staged.");

            // Step 2: Commit changes
            RunGitCommand($"commit -m \"{commitMessage}\"", repoPath);
            Console.WriteLine("Changes committed.");

            // Step 3: Push to the main branch
            RunGitCommand("push origin main", repoPath);
            Console.WriteLine("Changes pushed to GitHub.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    /// <summary>
    /// Executes a Git command in the specified repository path.
    /// </summary>
    /// <param name="command">The Git command to execute.</param>
    /// <param name="workingDirectory">The repository directory.</param>
    private static void RunGitCommand(string command, string workingDirectory)
    {
        var processInfo = new ProcessStartInfo
        {
            FileName = "git",
            Arguments = command,
            WorkingDirectory = workingDirectory,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using (var process = new Process { StartInfo = processInfo })
        {
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();
            process.WaitForExit();

            if (process.ExitCode != 0)
            {
                throw new InvalidOperationException($"Git command failed: {error}");
            }

            Console.WriteLine(output);
        }
    }
}
