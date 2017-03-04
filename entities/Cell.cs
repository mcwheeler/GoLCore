namespace GOLCore {
    public class Cell {
        public bool IsAlive {get; set;} 
        public void OnCycle(CellCycleContext cellContext) {
            //Console.WriteLine(cellContext.neighborCount);
            if(!IsAlive && cellContext.neighborCount == 3) {
                IsAlive = true;
                return;
            }

            //IsAlive
            if(cellContext.neighborCount > 3){
                IsAlive = false;
                return;
            }
            if(cellContext.neighborCount <= 1){
                IsAlive = false;
                return;
            }
        }
    }

    public class CellCycleContext {
        public int neighborCount {get; set;}
    }
}