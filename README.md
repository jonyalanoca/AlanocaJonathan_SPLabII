# CARTUCHERA DIGITAL

![](https://img.shields.io/static/v1?label=Cartuchera_Digital&message=v1.0&color=blue) 
`🧑‍💻 Jonathan Alanoca`


------------
Cartuchera Digital es un programa escrito en `c# - Windows forms` que nos permite agregar, modificar, eliminar, respaldar datos con base de datos y serialización
------------

![Sin título](https://user-images.githubusercontent.com/85081072/203143134-8ef28391-cf02-4245-8f4e-9cd1815d11b5.jpg)
#### Descripción del menú:
- ➕Agregar Util: Permite agregar un nuevo útil (lápiz,goma, sacapuntas).
- ✏️Modificar: Permite modificar cualquier registro seleccionado en la tabla.
- 🗑️Eliminar: Permite eliminar cualquier registro seleccionado en la tabla.
- 📝Ticket: Lee el archivo ticket.txt desde Mis Documentos. Este ticket contiene los registros en caso que la cartuchera exceda los $500
- ⬅️Serializar: Serializa el Lápiz seleccionado en JSON Y XML en un archivo .txt y .xml respectivamente en Mis Documentos.
- ➡️Deserializar: Importa los datos del archivo seleccionado(.txt y .xml) en el registro del lápiz seleccionado de la tabla.
- ℹ️ Informa: el tiempo activo en el programa (através de un hilo), precio total de la cartuchera y cantidad de útiles.
------------
**¿Como hacer una Agregar un útil?**

1. Pulsar ```Agregar```y nos abre un submenú de opciones(* ver imagen abajo).
1. Seleccionar el tipo de util que se desea añadir. Y se habilitan las opciones de agregado
2. Ingresar los datos del nuevo útil.
3. Pulsar ````Guardar```` o ````Descartar```` para finalizar la operación.<br>
![Sin título](https://user-images.githubusercontent.com/85081072/203149302-bcbc4d6b-192f-486d-8ec7-d102558e313c.jpg)

**¿Como Modificar un útil?**

1. Seleccionar el útil de la lista.
2. Darle a ```Modificar```. Y se habilitan las opciones de modificar.
3. Ingresar los nuevos datos.
4. Pulsar ````Guardar```` o ````Descartar```` para finalizar la operación

**¿Como eliminar un util?**

1. Seleccionar el útil de la lista.
2. Darle a ```Eliminar```. 
3. Confirmar la eliminación

**¿Como leer los tickets?**
1. Darle a ```Leer tickets```
1. Nos abre una nueva ventana con los registros del ticket.(*Ver imagen abajo)
1. Excepción: En caso de que la cartuchera no haya superado los $500 o no se encuentre el ticket.txt en Mis Documentos.<br>
![Sin título](https://user-images.githubusercontent.com/85081072/203151213-65b26b34-897a-4f32-b649-a2cb07dd9923.jpg).

**¿Como Serializar un Lápiz?**

1. Seleccionar un lápiz de la lista (ID: 2000-2999).
1. Darle a ```Serializar Lápiz```

1. Se guardará un archivo .txt (para Json) y un respaldo en un archivo .xlm (para XML). Ambos archivos en Mis Documentos.

**¿Como Deserializar Lápiz?**

1. Seleccionar un lápiz de la lista (ID: 2000-2999). Este modificará sus datos por el del archivo serializado.
1. Darle a ```Deserializar Lápiz```

1. Seleccionar el archivo en el gestor de archivos. Recomendación: buscar en Mis Documentos.(ver imagen abajo).<br>
![Sin título](https://user-images.githubusercontent.com/85081072/203154180-4f90d0e5-45ce-4c29-ac0f-74dd954a4995.jpg)
------------
Gracias por visitar.!
Programa hecho con mucho 🧡 por **Jonathan Alanoca**
Proyecto para el Segundo cuatrimestre **UTNFra**