class Figuras{

double bas;
double alt;
double lado;
double ancho;

double radio;
double result;

public void AreaTriangulo( double bases, double altura){

this.bas= bases;
this.alt = altura;

result = (this.bas * this.alt)/2 ;
}

public void Areacuadrado( double lado){

this.lado= lado;

result = lado * lado ;
}

public void Areareactangulo( double bases, double altura){
this.bas= bases;
this.alt = altura;

result = this.bas * this.alt;
}

public void Areacirculo( double radio){
this.radio= radio;

result = 3.141592 *(this.radio * this.radio);
}


public double GetResultado(){
    return this.result;
}

}