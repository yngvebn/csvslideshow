import { Component, OnInit } from '@angular/core';
import {ProjectService} from "./project.service";

@Component({
    selector: 'new-project',
    templateUrl: 'newProject.component.html'
})
export class NewProjectComponent implements OnInit {
    constructor(private projectService: ProjectService) {
    }

    create(name) {
        this.projectService.create(name);
    }

    ngOnInit() {
    }
}