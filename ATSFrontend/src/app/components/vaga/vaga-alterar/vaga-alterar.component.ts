import { Component, OnInit } from '@angular/core';
import { Vaga } from '../vaga.model';
import { VagaService } from '../vaga.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-vaga-alterar',
  templateUrl: './vaga-alterar.component.html',
  styleUrls: ['./vaga-alterar.component.css']
})
export class VagaAlterarComponent implements OnInit {
  vaga: Vaga = {
    idVaga: 0,
    descricao: '',
    profissao: '',
    dataCriacao: '',
    local: '',
    idCandidato: 0,
    candidatos: [{
      idCandidato: 0,
      nome: '',
      dataNascimento: ''
    }]
  }


  constructor(private vagaService: VagaService, private router: Router, private route: ActivatedRoute) { }

  ngOnInit(): void {
    const idVaga = this.route.snapshot.paramMap.get("idVaga");
    this.vagaService.detalhar(idVaga).subscribe((vaga) => {
      this.vaga = vaga;
      this.vaga.dataCriacao = this.vaga.dataCriacao.substring(0, 10)
    });
  }

  alterarVaga(): void {
    this.vagaService.alterar(this.vaga).subscribe(() => {
      this.vagaService.showMessage('Vaga Alterada!');
      this.router.navigate(['vagas/']);
    });
  }

  cancelar(): void {
    this.router.navigate(['vagas/']);
  }

}
