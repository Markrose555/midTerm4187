using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using midTerm4187.Models.Models.Option;


namespace midTerm4187.Services.Abstractions
{
    public interface IOptionService
    {
        Task<OptionModel> GetById(int id);

        Task<IEnumerable<OptionModel>> Get();

        Task<IEnumerable<OptionModel>> GetByQuestionId(int id);

        Task<OptionModel> Insert(OptionCreateModel model);

        Task<OptionModel> Update(OptionUpdateModel model);

        Task<bool> Delete(int id);
    }
}
