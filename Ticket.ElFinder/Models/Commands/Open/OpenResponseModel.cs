using System.Runtime.Serialization;

namespace Ticket.ElFinder.Models.Commands.Open
{
    [DataContract]
    public class OpenResponse : BaseOpenResponseModel
    {
        public OpenResponse(DirectoryModel currentWorkingDirectory, FullPath fullPath) : base(currentWorkingDirectory)
        {
            Options = new Options(fullPath);
            Files.Add(currentWorkingDirectory);
        }
    }
}