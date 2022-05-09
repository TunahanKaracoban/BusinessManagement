using Business.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IGenericService<T, TDto> where T : IEntityBase where TDto : IDtoBase
    {
        // ---- Ortak Bulunan Metotlar----
        //Listeleme
        IResponse<List<TDto>> GetAll();

        //Filtreli listeleme
        IResponse<List<TDto>> GetAll(Expression<Func<T, bool>> expression);


        //Getirme işlemi (Bulma)
        IResponse<TDto> Find(int id);


        //Kaydetme
        IResponse<TDto> Add(TDto item, bool saveChanges = true);


        //Güncelleme
        IResponse<TDto> Update(TDto item, bool saveChanges = true);



        //Silme
        IResponse<bool> DeleteById(int id, bool saveChanges = true);


        //IQueryable Listele
        IResponse<IQueryable<TDto>> GetQueryable();

        void Save();
    }
}
