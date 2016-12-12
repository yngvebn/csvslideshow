import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {RouterModule} from '@angular/router';
import {AppComponent} from "./app.component";
import {NewProjectComponent} from "./project/new-project.component";
import { HttpModule } from '@angular/http';
import {ProjectService} from "./project/project.service";

@NgModule({
    imports: [BrowserModule, HttpModule,
        RouterModule.forRoot([
            { path: '', component: NewProjectComponent }
        ])],
    declarations: [AppComponent, NewProjectComponent],
    providers: [ProjectService],
    bootstrap: [AppComponent]
})
export class AppModule {

}