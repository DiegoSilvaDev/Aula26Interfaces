namespace Interfaces
{
    public interface ICarrinho
    {
        // CRUD 
        // CREATE
        // READ
        // UPDTADE
        // DELETE

        void Ler();

        void Adicionar(Produto _produto);
        
        void Remover(Produto _produto);

        void Alterar(int _codigo, Produto _produtoAlterado);

        void MostrarTotal();
    }
}