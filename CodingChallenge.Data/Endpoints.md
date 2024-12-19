# Endpoints

## CalcularArea

Este método calcula el área de una figura utilizando los parámetros requeridos.

Endpoint: `GET /api/calcularArea`
Request:
```
{
	type: number,
	payload: {
		// ver payloads disponibles
	}
}
```

Donde `type`:

```
Cuadrado = 1,
TrianguloEquilatero = 2,  
Circulo = 3,  
Trapecio = 4,  
Rectangulo = 5,
```

Donde `payload` dependera del `type` elejido:

### Cuadrado
```
{
	lado: number
}
```
### TrianguloEquilatero
``` 
{
	lado: number
}
```
### Circulo
``` 
{
	diametro: number
}
```
### Trapecio
```
{
	baseMayor: number,
	baseMenor: number,
	lado1: number,
	lado2: number
}
```
### Rectangulo
```
{
	ancho: number,
	largo: number
}
```

## CalcularPerimetro

Este método calcula el perimetro de una figura utilizando los parámetros requeridos.

Endpoint: `GET /api/calcularPerimetro`
Request:
```
{
	type: number,
	payload: {
		// ver payloads disponibles
	}
}
```

Donde `type`:

```
Cuadrado = 1,
TrianguloEquilatero = 2,  
Circulo = 3,  
Trapecio = 4,  
Rectangulo = 5,
```

Donde `payload` dependera del `type` elejido:
### Cuadrado
```
{
	lado: number
}
```
### TrianguloEquilatero
``` 
{
	lado: number
}
```
### Circulo
``` 
{
	diametro: number
}
```
### Trapecio
```
{
	baseMayor: number,
	baseMenor: number,
	lado1: number,
	lado2: number
}
```
### Rectangulo
```
{
	ancho: number,
	largo: number
}
```