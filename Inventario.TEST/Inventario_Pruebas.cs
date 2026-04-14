namespace Inventario.TEST
{
    public class Inventario_Pruebas
    {
        [Fact]
        public void Prueba_Agregar_Un_Producto()
        {
            //Arrage
            BL.GestorInventario gestorInventario = new BL.GestorInventario();
            MODEL.Producto producto = new MODEL.Producto();
            int tamanoDeLaLista = gestorInventario.ObtenerProductos().Count();
            producto.Id = gestorInventario.ObtenerProductos().Count() + 1;
            producto.Nombre = "Case";
            producto.Precio = 156.786;
            producto.Stock = 2;

            //Act
            gestorInventario.AgregarProducto(producto);
            var listaProductos = gestorInventario.ObtenerProductos();

            //Assert
            Assert.Contains(producto, listaProductos);
        }

        [Fact]
        public void Prueba_Eliminar_Un_Producto()
        {
            //Arrage
            BL.GestorInventario gestorInventario = new BL.GestorInventario();
            MODEL.Producto producto = new MODEL.Producto();
            int id = 1;


            //Act
            gestorInventario.EliminarProducto(id);
            var listaProductos = gestorInventario.ObtenerProductos();

            //Assert
            Assert.DoesNotContain(producto, listaProductos);
        }

        [Fact]
        public void Prueba_Buscar_Producto_Por_Nombre()
        {
            //Arrage
            BL.GestorInventario gestorInventario = new BL.GestorInventario();
            string nombreProducto = "Laptop";


            //Act
            var listaProductos = gestorInventario.BuscarProductosPorNombre(nombreProducto);


            Assert.All(listaProductos, p => Assert.Contains(nombreProducto, p.Nombre));
        }

        [Fact]
        public void Prueba_Buscar_Producto_Por_Categoria()
        {
            //Arrage
            BL.GestorInventario gestorInventario = new BL.GestorInventario();
            string categoriaProducto = "Tecnología";


            //Act
            var listaProductos = gestorInventario.BuscarProductosPorCategoria(categoriaProducto);


            Assert.All(listaProductos, p => Assert.Contains(categoriaProducto, p.Categoria));
        }
    }
}
