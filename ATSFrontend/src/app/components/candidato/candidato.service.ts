import { Candidato } from './candidato.model';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { EMPTY, Observable } from 'rxjs';
import { map, catchError } from "rxjs/operators";

@Injectable({
  providedIn: 'root'
})
export class CandidatoService {
  baseUrl = "https://localhost:5001/api/candidato";

  constructor(private snackBar: MatSnackBar, private http: HttpClient) { }

  showMessage(msg: string, houveErro: boolean = false): void {
    this.snackBar.open(msg, '', {
      duration: 3000,
      horizontalPosition: 'right',
      verticalPosition: 'top',
      panelClass: houveErro ? ["msg-error"] : ["msg-success"],
    });
  }

  criar(candidato: Candidato): Observable<Candidato> {
    return this.http.post<Candidato>(this.baseUrl, candidato)
      .pipe(map((obj) => obj),
        catchError((e) => this.errorHandler(e)));
  }

  alterar(candidato: Candidato): Observable<Candidato> {
    return this.http.patch<Candidato>(`${this.baseUrl}/${candidato.idCandidato}`, candidato)
      .pipe(map((obj) => obj),
        catchError((e) => this.errorHandler(e)));
  }

  excluir(idCandidato: any): Observable<Candidato> {
    return this.http.delete<Candidato>(`${this.baseUrl}/${idCandidato}`)
      .pipe(map((obj) => obj),
        catchError((e) => this.errorHandler(e)));
  }

  excluirExperienciaCadidato(idExperiencia: any): Observable<Candidato> {
    return this.http.delete<Candidato>(`${this.baseUrl}/experiencia/${idExperiencia}`)
      .pipe(map((obj) => obj),
        catchError((e) => this.errorHandler(e)));
  }

  detalhar(idCandidato: any): Observable<Candidato> {
    return this.http.get<Candidato>(`${this.baseUrl}/${idCandidato}`)
      .pipe(map((obj) => obj),
        catchError((e) => this.errorHandler(e)));
  }

  listar(): Observable<Candidato[]> {
    return this.http.get<Candidato[]>(this.baseUrl)
      .pipe(map((obj) => obj),
        catchError((e) => this.errorHandler(e)));
  }

  listarCadidatosVaga(idVaga: any): Observable<Candidato[]> {
    return this.http.get<Candidato[]>(`${this.baseUrl}/candidatos/${idVaga}`)
      .pipe(map((obj) => obj),
        catchError((e) => this.errorHandler(e)));
  }

  errorHandler(e: any): Observable<any> {
    this.showMessage("Houve um erro", true);
    // return EMPTY;
    return e;
  }
}
