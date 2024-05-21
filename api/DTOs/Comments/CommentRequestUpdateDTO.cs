using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using api.DTOs;
using System.ComponentModel.DataAnnotations;

namespace api.DTOs
{
    public class CommentRequestUpdateDTO
    {
       
         [Required]
        [MinLength(5,ErrorMessage = "Title must be 5 characters")]
        [MaxLength(280,ErrorMessage = "Title can not exceed over 280 characters")]
        public string? Title {get; set;}

        [Required]
        [MinLength(5,ErrorMessage = "content must be 5 characters")]
        [MaxLength(280,ErrorMessage = "content can not exceed over 280 characters")]
        public string? Content {get; set;}
        
     

      

    }
}