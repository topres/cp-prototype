using System;

namespace CustomerPortalPrototype.Domain.RobotRegistration
{
    public class RobotRegistrationRepository
    {
        public RegistrationModel[] All()
        {
            return new[]
            {
                new RegistrationModel(Guid.NewGuid(), "assembly robot"),
                new RegistrationModel(Guid.NewGuid(), "palletizing robot"),
                new RegistrationModel(Guid.NewGuid(), "new test"),
            };
        }
    }
}