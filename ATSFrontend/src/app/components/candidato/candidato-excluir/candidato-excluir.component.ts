import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Candidato } from '../candidato.model';
import { CandidatoService } from '../candidato.service';

@Component({
  selector: 'app-candidato-excluir',
  templateUrl: './candidato-excluir.component.html',
  styleUrls: ['./candidato-excluir.component.css']
})
export class CandidatoExcluirComponent implements OnInit {

  candidato: Candidato = {
    idCandidato: 0,
    nome: '',
    ativo: true,
    profissao: '',
    dataNascimento: '',
    curriculo: {
      idCurriculo: 0,
      idCandidato: 0,
      idExperiencia: 0,
      formacaoAcademica: '',
      experiencias: [{
        idExperiencia: 0,
        nomeEmpresa: '',
        dataInicio: '',
        dataFim: ''
      }]
    },
  };

  constructor(private candidatoService: CandidatoService, private router: Router, private route: ActivatedRoute) { }

  ngOnInit(): void {
    const idCandidato = this.route.snapshot.paramMap.get("idCandidato");
    this.candidatoService.detalhar(idCandidato).subscribe((candidato) => {
      this.candidato = candidato;
      this.candidato.dataNascimento = this.candidato.dataNascimento.substring(0, 10)
    });
  }

  excluirCandidato(): void {
    this.candidatoService.excluir(this.candidato.idCandidato).subscribe(() => {
      console.log(this.candidato)
      this.candidatoService.showMessage('Candidato Excluído!', true);
      this.router.navigate(['candidatos/']);
    });
  }

  cancelar(): void {
    this.router.navigate(['candidatos/']);
  }
}
