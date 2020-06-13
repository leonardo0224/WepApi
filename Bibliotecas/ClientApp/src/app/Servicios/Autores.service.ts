import {HttpClient, HttpHeaders} from "@angular/common/http";
import {Observable} from "rxjs/internal/observable";
import { Injectable } from '@angular/core';
import { Autor } from '../Models/Autor';

@Injectable({
  providedIn: 'root'
})
export class AutoresService {
  public selectdAutor: Autor= {
    IdAutor: '0',
    Nombre: '',
    Apellido: '',
    FechaNacimiento: ''
  };

constructor(private http:HttpClient) { }

getAutor(){
  const url='http://localhost:58034/api/Autor';
  return this.http.get(url);
}

AgregarAutor(autor: Autor): Observable<Autor>{
  debugger;
  const url='http://localhost:58034/api/Autor';
  return this.http.post<Autor>(url , autor);
}

EditarAutor(autor: Autor): Observable<Autor>{
  const url='http://localhost:58034/api/Autor';
  return this.http.put<Autor>(url, autor);
}


}
