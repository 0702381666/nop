import React from 'react';
import { ScrollView, TouchableOpacity, Text } from 'react-native';

const CategorySelector = ({ categories, selected, onSelect }) => {
  return (
    <ScrollView horizontal>
      {categories.map(category => (
        <TouchableOpacity key={category.id} onPress={() => onSelect(category.id)}>
          <Text style={{ fontWeight: selected === category.id ? 'bold' : 'normal' }}>{category.name}</Text>
        </TouchableOpacity>
      ))}
    </ScrollView>
  );
};

export default CategorySelector;
