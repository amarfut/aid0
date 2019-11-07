using System;

namespace Domain.Commands
{
    public class CreateUserCommand : IDomainCommand
    {
        public CreateUserCommand(string externalId, string name, string provider)
        {
            ExternalId = externalId;
            Name = name;
            Provider = provider;
        }

        public string ExternalId { get; set; }

        public string Name { get; set; }

        public string Provider { get; set; }
    }
}
