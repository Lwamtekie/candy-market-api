import React from 'react';
import getallCandies from '../../helpers/data/getData';


class Candy extends React.Component { 

    state = {
        candies : []
    };

    componentDidMount() {
        getallCandies.getallCandies().then(data => {
            this.setState({candies:data});
        });
    }

    buildCandies= () => this.state.candies.map(t => (
        <div key={t.id}>{t.name}</div>
    ));

    render() {
        return (
            <React.Fragment>
                {this.buildCandies()}
            </React.Fragment>
        )
    }
}

export default Candy;