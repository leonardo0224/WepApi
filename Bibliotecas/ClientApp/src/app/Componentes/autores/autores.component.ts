import { Component, OnInit, ViewChild, Inject } from '@angular/core';
import {MatPaginator} from '@angular/material/paginator';
import {MatTableDataSource} from '@angular/material/table';
import { AutoresService } from 'src/app/Servicios/Autores.service';
import { Autor } from 'src/app/Models/Autor';

@Component({
  selector: 'app-autores',
  templateUrl: './autores.component.html',
  styleUrls: ['./autores.component.css']
})
export class AutoresComponent implements OnInit {

  constructor(public AutorService: AutoresService) { }
  public autores: Autor[];
  public autor: Autor;
  lista: string[];
  pageActual: number = 1;
  public cont: number = 1;

  ngOnInit() {
    this.consultarAutor();
  }
  consultarAutor(){
    this.AutorService.getAutor()
    .subscribe((res:any) =>{
      this.autores = res;
    });
  }
  onSaveAutores(autorForm:Autor){
    this.AutorService.AgregarAutor(autorForm)
    .subscribe(res => this.autores.push(res));
   }

   Editar(autorEditar: Autor){
      this.AutorService.EditarAutor(autorEditar)
      .subscribe(res => this.autores);

   }
}




