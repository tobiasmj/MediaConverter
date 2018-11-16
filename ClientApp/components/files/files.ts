import Vue from 'vue';
import { Component } from 'vue-property-decorator';

interface IFiles {
    name: string;
}

@Component
export default class FetchDataComponent extends Vue {
    files: IFiles[] = [];

    mounted() {
        fetch('api/File/Files')
            .then(response => response.json() as Promise<IFiles[]>)
            .then(data => {
                this.files = data;
            });
    }
}
