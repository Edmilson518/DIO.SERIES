using System.collections.generic;
 
namespace DIO.series.interfaces
{
    public interface IRepositorio<T>
    {
      list<t> lista();
      T retornaId(int id);
      void Insere(T entidade);
      void excluir(int id);
      void atualiza(int id, T entidade);
      int proximoId();

    }
}