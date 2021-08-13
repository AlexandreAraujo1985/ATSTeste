import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Vaga } from './vaga.model';
import { EMPTY, Observable } from 'rxjs';
import { map, catchError } from "rxjs/operators";

@Injectable({
  providedIn: 'root'
})
export class VagaService {

  baseUrl = "https://localhost:5001/api/vaga";

  constructor(private snackBar: MatSnackBar, private http: HttpClient) { }

  showMessage(msg: string, houveErro: boolean = false): void {
    this.snackBar.open(msg, '', {
      duration: 3000,
      horizontalPosition: 'right',
      verticalPosition: 'top',
      panelClass: houveErro ? ["msg-error"] : ["msg-success"],
    });
  }

  criar(vaga: Vaga): Observable<Vaga> {
    return this.http.post<Vaga>(this.baseUrl, vaga)
      .pipe(map((obj) => obj),
        catchError((e) => this.errorHandler(e)));
  }

  alterar(vaga: Vaga): Observable<Vaga> {
    return this.http.patch<Vaga>(`${this.baseUrl}/${vaga.idVaga}`, vaga)
      .pipe(map((obj) => obj),
        catchError((e) => this.errorHandler(e)));
  }

  excluir(idVaga: any): Observable<Vaga> {
    return this.http.delete<Vaga>(`${this.baseUrl}/${idVaga}`)
      .pipe(map((obj) => obj),
        catchError((e) => this.errorHandler(e)));
  }

  detalhar(idVaga: any): Observable<Vaga> {
    return this.http.get<Vaga>(`${this.baseUrl}/${idVaga}`)
      .pipe(map((obj) => obj),
        catchError((e) => this.errorHandler(e)));
  }

  listar(): Observable<Vaga[]> {
    return this.http.get<Vaga[]>(this.baseUrl)
      .pipe(map((obj) => obj),
        catchError((e) => this.errorHandler(e)));
  }

  errorHandler(e: any): Observable<any> {
    this.showMessage("Houve um erro", true);
    return e;
  }
}
