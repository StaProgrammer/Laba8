public class GraphVisualizer
{
    public void Visualize(GraphFactory factory)
    {
        Chart chart = factory.CreateChart();
        chart.Draw();
    }
}
