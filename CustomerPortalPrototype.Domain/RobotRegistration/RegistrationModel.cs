using System;

namespace CustomerPortalPrototype.Domain.RobotRegistration
{
    public class RegistrationModel
    {
        public RegistrationModel(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; }
        public string Name { get; }
    }
}
