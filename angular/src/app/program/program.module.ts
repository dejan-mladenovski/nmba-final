import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProgramComponent } from './program.component';
import { Routes, RouterModule } from '@angular/router';
import { PageHeaderModule } from './../shared';

const routes: Routes = [
    { path: '', component: ProgramComponent }
];


@NgModule({
  imports: [
    CommonModule, PageHeaderModule,RouterModule.forChild(routes)
  ],
  declarations: [ProgramComponent]
})

export class ProgramModule { }
