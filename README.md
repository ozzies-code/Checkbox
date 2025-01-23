# Project Title: Checkbox
 
El Proyecto se basa en una aplicacion que demuestra el uso que puede 
darse al control objeto Checkbox.


# Descripcion

 Este proyecto consiste en el desarrollo de una aplicacion que 
 presenta una serie de opciones a traves de unos checkbox para
 obtener un determinado resultado que sera determinado por la 
 logica del codigo para sumar o restar puentos dependiendo de 
 cada checkbox marcado como correcto. 
 
 # Actualizacion: 23/01/2025
 # Hora: 18:55

Detalles técnicos del proyecto:
Idioma: Visual Basic.NET
Versión del framework: 4.7.2

## Autores

- [@ozzies-code](https://www.github.com/ozzies-code)

## Contribuciones

¡Las contribuciones son siempre bienvenidas!

Consulta `contributing.md` para conocer cómo comenzar.

Por favor, respeta el `código de conducta` de este proyecto.

## Despliegue

Para implementar este proyecto, descargue los archivos del proyecto
del repositorio y el código del proyecto que se encuentra
en el archivo README.md

## 🚀 Acerca de Mi
Soy un apasionado desarrollador fullstack de Venezuela 🇻🇪 y Países Bajos 🇳🇱


🔭 Actualmente estoy trabajando en .NET Framework

🔭 Actualmente estoy trabajando en desarrollo web

🔭 Actualmente estoy trabajando en proyectos de .Console

🔭 Actualmente estoy trabajando en bases de datos .SQL

🌱 Actualmente estoy aprendiendo sobre frameworks, cursos, tutoriales y libros electrónicos

💬 Pregúntame sobre desarrollo de software

📫 Cómo contactarme oswaldojmp.nl@proton.me

👨‍💻 Todos mis proyectos están disponibles en https://developerandtechnologyozziescode.blogspot.com/ (mi sitio web)

📝 Escribo artículos regularmente en Medium.com/Ozzies.Code

    ## 🔗 Links
[![portfolio](https://img.shields.io/badge/my_portfolio-000?style=for-the-badge&logo=ko-fi&logoColor=white)]( https://developerandtechnologyozziescode.blogspot.com)
[![linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](www.linkedin.com/in/oswaldo-jesús-marín-pagés-ab4499a4)
[![twitter](https://img.shields.io/badge/twitter-1DA1F2?style=for-the-badge&logo=twitter&logoColor=white)](https://twitter.com/ozzies_code)

## Lecciones Aprendidas

- Manejo del Checkbox
- eventos del Checkbox
- logica de programacion

## image of the Project

![imagen](https://github.com/user-attachments/assets/227a0811-8fbb-43b0-af30-8341759b3a34)

## Soporte

Para soporte, email oswaldojmp.nl@proton.me

## Pila de tecnología

**Plataforma:** Visual studio 2022

**Lenguaje:** Visual Basic.NET

Codigo del Proyecto:

Public Class Form1
    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click

        'Declaracion de variables
        'Dependiendo de la activacion de cada checkbox se sumaran o restaran puntos al resultado
        'El resultado se mostrara por un cuadro de mensaje

        Dim puntos As Double = 0

        If chClase.Checked = True Then
            puntos += 2.5
        End If

        If chObjeto.Checked = True Then
            puntos += 2.5
        End If

        If chBucle.Checked = True Then
            puntos -= 2.5
        End If

        If chHerencia.Checked = True Then
            puntos += 2.5
        End If

        If chPolimorfismo.Checked = True Then
            puntos += 2.5
        End If

        MsgBox("El total de puntos obtenidos es " & puntos)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Se desactivan los checkbox al inicio del programa

        chPolimorfismo.Checked = False
        chBucle.Checked = False
        chClase.Checked = False
        chHerencia.Checked = False
        chObjeto.Checked = False
    End Sub
End Class
