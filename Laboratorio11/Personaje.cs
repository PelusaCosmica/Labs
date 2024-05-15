class Personaje{

public int x = 0;
public int y = 0;

public Personaje(int x, int y){
 this.x = x;
 this.y = y;
}

public void MoverHaciaDerecha(int cant){
    x+=cant;
}
public void MoverHaciaIzquierda(int cant){
    x-=cant;
}
public void MoverHaciaArriba(int cant){
    y+=cant;
}
public void MoverHaciaAbajo(int cant){
    y-=cant;
}
}