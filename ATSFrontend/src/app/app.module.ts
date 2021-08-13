import { MatSnackBar } from '@angular/material/snack-bar';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HeaderComponent } from './components/template/header/header.component';

import { MatToolbarModule } from '@angular/material/toolbar';
import { FooterComponent } from './components/template/footer/footer.component';
import { NavComponent } from './components/template/nav/nav.component';

import { MatSidenavModule } from '@angular/material/sidenav';
import { MatCardModule } from '@angular/material/card';
import { MatListModule } from '@angular/material/list';
import { HomeComponent } from './views/home/home.component';
import { CandidatoCrudComponent } from './views/candidato-crud/candidato-crud.component';
import { VagasCrudComponent } from './views/vagas-crud/vagas-crud.component';
import { CandidatoCriarComponent } from './components/candidato/candidato-criar/candidato-criar.component';

import { MatButtonModule } from '@angular/material/button';
import { MatSnackBarModule } from '@angular/material/snack-bar';

import { HttpClientModule } from '@angular/common/http';

import { FormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { CandidatoListarComponent } from './components/candidato/candidato-listar/candidato-listar.component';

import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
import { CandidatoAlterarComponent } from './components/candidato/candidato-alterar/candidato-alterar.component';
import { CandidatoExcluirComponent } from './components/candidato/candidato-excluir/candidato-excluir.component';
import { VagaListarComponent } from './components/vaga/vaga-listar/vaga-listar.component';
import { VagaCriarComponent } from './components/vaga/vaga-criar/vaga-criar.component';
import { VagaAlterarComponent } from './components/vaga/vaga-alterar/vaga-alterar.component';
import { VagaExcluirComponent } from './components/vaga/vaga-excluir/vaga-excluir.component';
import { CandidatoVagaComponent } from './components/candidato/candidato-vaga/candidato-vaga.component';
import { VagaCandidatosComponent } from './components/vaga/vaga-candidatos/vaga-candidatos.component';

import { MatProgressSpinnerModule} from '@angular/material/progress-spinner';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    NavComponent,
    HomeComponent,
    CandidatoCrudComponent,
    VagasCrudComponent,
    CandidatoCriarComponent,
    CandidatoListarComponent,
    CandidatoAlterarComponent,
    CandidatoExcluirComponent,
    VagaListarComponent,
    VagaCriarComponent,
    VagaAlterarComponent,
    VagaExcluirComponent,
    CandidatoVagaComponent,
    VagaCandidatosComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatSidenavModule,
    MatListModule,
    MatCardModule,
    MatButtonModule,
    MatSnackBarModule,
    HttpClientModule,
    FormsModule,
    MatFormFieldModule,
    MatInputModule,
    MatTableModule,
    MatPaginatorModule,
    MatProgressSpinnerModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
