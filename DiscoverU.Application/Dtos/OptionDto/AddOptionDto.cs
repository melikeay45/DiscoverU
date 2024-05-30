using DiscoverU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverU.Application.Dtos.OptionDto
{
    public class AddOptionDto
    {
        public string Text { get; set; }
        public Guid QuestionId { get; set; }

        public static Option MapToOption(AddOptionDto addOptionDto)
        {
            return new Option
            { 
                Id=Guid.NewGuid(),
                Text = addOptionDto.Text,
                QuestionId = addOptionDto.QuestionId,
            };
            
        }

    }
}
