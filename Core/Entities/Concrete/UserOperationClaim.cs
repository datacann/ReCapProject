﻿namespace Core.Entities.Concrete
{
    public class UserOperationClaim : IEntities
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int OperationClaimID { get; set; }

    }
}
