import React from 'react';
import { View, Text, Pressable } from 'react-native';

const AddonOptions = ({ addons, selectedAddons, onToggle }) => {
  return (
    <View>
      {addons.map((addon) => {
        const selected = selectedAddons.some(a => a.label === addon.label);
        return (
          <Pressable
            key={addon.label}
            onPress={() => onToggle(addon)}
            style={{
              flexDirection: 'row',
              alignItems: 'center',
              marginVertical: 5,
            }}
          >
            <View style={{
              height: 20,
              width: 20,
              borderWidth: 1,
              borderColor: '#000',
              marginRight: 8,
              justifyContent: 'center',
              alignItems: 'center',
              backgroundColor: selected ? '#000' : 'transparent'
            }}>
              {selected && <View style={{ height: 10, width: 10, backgroundColor: 'white' }} />}
            </View>
            <Text>{addon.label} - ${addon.price.toFixed(2)}</Text>
          </Pressable>
        );
      })}
    </View>
  );
};

export default AddonOptions;