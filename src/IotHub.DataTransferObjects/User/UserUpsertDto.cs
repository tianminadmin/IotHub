﻿using IotHub.Common.Enums;
using IotHub.DataTransferObjects.Base;
using System.ComponentModel.DataAnnotations;

namespace IotHub.DataTransferObjects.User
{
    public class UserUpsertDto : BaseDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
        [Required]
        public UserType Type { get; set; }
        public bool IsActive { get; set; }
    }
}
