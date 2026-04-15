using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [SetUp]
        public void SetUp()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-AR");
        }

        // ── Lista vacía ───────────────────────────────────────────────────────

        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                ReporteFormas.Imprimir(new List<FormaGeometrica>(), new Castellano()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                ReporteFormas.Imprimir(new List<FormaGeometrica>(), new Ingles()));
        }

        [TestCase]
        public void TestResumenListaVaciaEnItaliano()
        {
            Assert.AreEqual("<h1>Lista vuota di forme!</h1>",
                ReporteFormas.Imprimir(new List<FormaGeometrica>(), new Italiano()));
        }

        // ── Un solo tipo ──────────────────────────────────────────────────────

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var formas = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = ReporteFormas.Imprimir(formas, new Castellano());

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = ReporteFormas.Imprimir(formas, new Ingles());

            Assert.AreEqual(
                "<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35",
                resumen);
        }

        // ── Múltiples tipos ───────────────────────────────────────────────────

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = ReporteFormas.Imprimir(formas, new Ingles());

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = ReporteFormas.Imprimir(formas, new Castellano());

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }

        // ── Trapecio ──────────────────────────────────────────────────────────

        [TestCase]
        public void TestResumenListaConUnTrapecioEnCastellano()
        {
            // baseMayor=8, baseMenor=4, altura=3
            // Area = (8+4)/2 * 3 = 18
            // Lado lateral = sqrt(2^2 + 3^2) = sqrt(13) ≈ 3,61
            // Perimetro = 8 + 4 + 2*sqrt(13) ≈ 19,21
            var formas = new List<FormaGeometrica> { new Trapecio(8, 4, 3) };

            var resumen = ReporteFormas.Imprimir(formas, new Castellano());

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>1 Trapecio | Area 18 | Perimetro 19,21 <br/>TOTAL:<br/>1 formas Perimetro 19,21 Area 18",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConVariosTrapeciosEnIngles()
        {
            // Trapecio 1: baseMayor=8, baseMenor=4, altura=3  → Area=18,  Perim≈19,21
            // Trapecio 2: baseMayor=6, baseMenor=2, altura=4  → Area=16,  Perim≈16,94
            var formas = new List<FormaGeometrica>
            {
                new Trapecio(8, 4, 3),
                new Trapecio(6, 2, 4)
            };

            var resumen = ReporteFormas.Imprimir(formas, new Ingles());

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Trapezoids | Area 34 | Perimeter 36,16 <br/>TOTAL:<br/>2 shapes Perimeter 36,16 Area 34",
                resumen);
        }

        // ── Italiano ──────────────────────────────────────────────────────────

        [TestCase]
        public void TestResumenListaConMasTiposEnItaliano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = ReporteFormas.Imprimir(formas, new Italiano());

            Assert.AreEqual(
                "<h1>Rapporto sulle forme</h1>2 Quadrati | Area 29 | Perimetro 28 <br/>2 Cerchi | Area 13,01 | Perimetro 18,06 <br/>3 Triangoli | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 forme Perimetro 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecioEnItaliano()
        {
            var formas = new List<FormaGeometrica> { new Trapecio(8, 4, 3) };

            var resumen = ReporteFormas.Imprimir(formas, new Italiano());

            Assert.AreEqual(
                "<h1>Rapporto sulle forme</h1>1 Trapezio | Area 18 | Perimetro 19,21 <br/>TOTAL:<br/>1 forme Perimetro 19,21 Area 18",
                resumen);
        }
    }
}
